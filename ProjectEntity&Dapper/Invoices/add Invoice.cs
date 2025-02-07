using Microsoft.EntityFrameworkCore;
using ProjectEntity_Dapper.Customer;
using ProjectEntity_Dapper.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjectEntity_Dapper.Invoice
{
    public partial class frm_add_Invoice : Form
    {
        private WarehouseDBContext dbContext;

        public frm_add_Invoice()
        {
            InitializeComponent();
            InitializeDbContext();
            InitializeDataGridView();
            InitializeFormControls();
        }

        private void InitializeDbContext()
        {
            dbContext = new WarehouseDBContext();
            dbContext.Database.EnsureCreated();
        }

        private void InitializeFormControls()
        {
            LoadCustomers();
            LoadProducts();
            lbl_IDGenerator.Text = GenerateInvoiceNumber();
            dtpInvoiceDate.Value = DateTime.Now;
        }


        private void InitializeDataGridView()
        {
            // تنظيف الأعمدة الحالية
            dgv_invoiceDetails.Columns.Clear();

            // إعداد خصائص DataGridView
            dgv_invoiceDetails.AutoGenerateColumns = false;
            dgv_invoiceDetails.AllowUserToAddRows = false;

            // إنشاء الأعمدة
            var columns = new DataGridViewColumn[]
            {
        new DataGridViewTextBoxColumn
        {
            HeaderText = "Product",
            Name = "Product",
            ReadOnly = true
        },
        new DataGridViewTextBoxColumn
        {
            HeaderText = "Quantity",
            Name = "Quantity",
            ValueType = typeof(int)
        },
        new DataGridViewTextBoxColumn
        {
            HeaderText = "Unit Price",
            Name = "UnitPrice",
            ValueType = typeof(decimal),
            ReadOnly = true
        },
        new DataGridViewTextBoxColumn
        {
            HeaderText = "Total Price",
            Name = "TotalPrice",
            ValueType = typeof(decimal),
            ReadOnly = true
        },
        new DataGridViewTextBoxColumn
        {
            HeaderText = "Stock",
            Name = "Stock",
            ReadOnly = true
        },
        new DataGridViewButtonColumn
        {
            HeaderText = "Delete",
            Name = "Delete",
            Text = "Delete",
            UseColumnTextForButtonValue = true,
            Width = 60
        }
            };

            // إضافة الأعمدة إلى DataGridView
            dgv_invoiceDetails.Columns.AddRange(columns);
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            if (!ValidateProductSelection()) return;

            using (var tempContext = new WarehouseDBContext())
            {
                var product = tempContext.Products.Find((int)comboBoxProducts.SelectedValue);

                if (product == null)
                {
                    ShowErrorMessage("Product not found!");
                    return;
                }

                if (!ValidateProductQuantity(product, (int)numUDQuantity.Value)) return;

                AddProductToGrid(product, (int)numUDQuantity.Value);
                ClearProductFields();
            }
        }

        private bool ValidateProductSelection()
        {
            if (comboBoxProducts.SelectedValue == null || numUDQuantity.Value == 0)
            {
                ShowWarningMessage("Please select a product and enter a quantity.");
                return false;
            }
            return true;
        }

        private bool ValidateProductQuantity(Product product, int requestedQuantity)
        {
            if (product.Quantity >= requestedQuantity) return true;

            ShowWarningMessage($"Insufficient stock! Available quantity: {product.Quantity}");
            return false;
        }

        private void AddProductToGrid(Product product, int quantity)
        {
            dgv_invoiceDetails.Rows.Add(
                product.Name,
                quantity,
                product.Price,
                quantity * product.Price,
                product.Quantity
            );

            UpdateTotalAmount();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (!ValidateInvoice()) return;

            using (var transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    var invoice = CreateInvoice();
                    ProcessInvoiceItems(invoice);

                    transaction.Commit();
                    ShowSuccessMessage("Invoice saved successfully!");
                    ResetForm();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    HandleException(ex);
                }
            }
        }

        private bool ValidateInvoice()
        {
            if (dgv_invoiceDetails.Rows.Count == 0)
            {
                ShowWarningMessage("Please add invoice details first.");
                return false;
            }

            if (comboBoxCustomers.SelectedValue == null)
            {
                ShowWarningMessage("Please select a customer.");
                return false;
            }

            return true;
        }

        private Invoicess CreateInvoice()
        {
            var invoic = new Invoicess
            {
                InvoiceNumber = lbl_IDGenerator.Text,
                InvoiceDate = dtpInvoiceDate.Value,
                CustomerId = (int)comboBoxCustomers.SelectedValue,
                Notes = txt_note.Text,
                TotalAmount = GetTotalAmount()
            };

            dbContext.Invoices.Add(invoic);
            dbContext.SaveChanges();
            return invoic;
        }

        private void ProcessInvoiceItems(Invoicess invoice)
        {
            foreach (DataGridViewRow row in dgv_invoiceDetails.Rows)
            {
                if (row.Cells["Product"].Value == null || row.Cells["Quantity"].Value == null) continue;

                var productName = row.Cells["Product"].Value.ToString();
                var quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                var product = dbContext.Products.FirstOrDefault(p => p.Name == productName);

                if (product == null) continue;

                ValidateStock(product, quantity);
                UpdateProductStock(product, quantity);
                CreateInvoiceDetail(invoice, product, quantity);
            }

            dbContext.SaveChanges();
        }

        private void ValidateStock(Product product, int quantity)
        {
            if (product.Quantity < quantity)
            {
                throw new Exception($"Insufficient stock for product {product.Name}. Available: {product.Quantity}");
            }
        }

        private void UpdateProductStock(Product product, int quantity)
        {
            product.Quantity -= quantity;
            dbContext.Entry(product).State = EntityState.Modified;
        }

        private void CreateInvoiceDetail(Invoicess invoice, Product product, int quantity)
        {
            dbContext.InvoiceDetails.Add(new InvoiceDetail
            {
                InvoiceId = invoice.InvoiceId,
                ProductId = product.Id,
                Quantity = quantity,
                UnitPrice = product.Price
            });
        }

        private void dgv_invoiceDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
              
                if (e.RowIndex < 0)
                {
                    return; 
                }

             
                if (dgv_invoiceDetails.Columns[e.ColumnIndex].Name == "Delete")
                {
                  
                    if (ConfirmDelete())
                    {
                  
                        RemoveRow(e.RowIndex);

                      
                        UpdateStockDisplay();
                        UpdateTotalAmount();
                    }
                }
            }
            catch (Exception ex)
            {
              
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ConfirmDelete()
        {
            return MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void RemoveRow(int rowIndex)
        {
            dgv_invoiceDetails.Rows.RemoveAt(rowIndex);
        }

        private void UpdateStockDisplay()
        {
            foreach (DataGridViewRow row in dgv_invoiceDetails.Rows)
            {
                if (row.Cells["Product"].Value == null) continue;

                using (var db = new WarehouseDBContext())
                {
                    var product = db.Products.AsNoTracking()
                        .FirstOrDefault(p => p.Name == row.Cells["Product"].Value.ToString());

                    if (product != null)
                    {
                        row.Cells["Stock"].Value = product.Quantity;
                    }
                }
            }
        }

        private void UpdateTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dgv_invoiceDetails.Rows)
            {
                if (row.Cells["TotalPrice"].Value != null)
                {
                    totalAmount += Convert.ToDecimal(row.Cells["TotalPrice"].Value);
                }
            }

            lblTotalAmount.Text = $"Total Amount: {totalAmount:C2}";
        }

        private string GenerateInvoiceNumber()
        {
            return "INV-" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void LoadProducts()
        {
            using (var db = new WarehouseDBContext())
            {
                var products = db.Products.AsNoTracking().ToList();
                comboBoxProducts.DataSource = products;
                comboBoxProducts.DisplayMember = "Name";
                comboBoxProducts.ValueMember = "Id";
            }
        }

        private void LoadCustomers()
        {
            dbContext.Customer.Load();
            comboBoxCustomers.DataSource = dbContext.Customer.Local.ToBindingList();
            comboBoxCustomers.DisplayMember = "CustomerName";
            comboBoxCustomers.ValueMember = "Id";
        }

        private void ClearProductFields()
        {
            comboBoxProducts.SelectedIndex = -1;
            numUDQuantity.Value = 0;
        }

        private void ResetForm()
        {
            lbl_IDGenerator.Text = GenerateInvoiceNumber();
            dtpInvoiceDate.Value = DateTime.Now;
            comboBoxCustomers.SelectedIndex = -1;
            txt_phone.Clear();
            txt_note.Clear();
            dgv_invoiceDetails.Rows.Clear();
            lblTotalAmount.Text = "Total Amount: $0.00";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void HandleException(Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private decimal GetTotalAmount()
        {
            return Convert.ToDecimal(lblTotalAmount.Text.Replace("Total Amount: ", "").Replace("$", ""));
        }

        private void OnCustomerUpdated(Customers newCustomer)
        {
            var customers = dbContext.Customer.AsNoTracking().ToList();
            comboBoxCustomers.DataSource = customers;
            comboBoxCustomers.DisplayMember = "CustomerName";
            comboBoxCustomers.ValueMember = "Id";
            comboBoxCustomers.SelectedValue = newCustomer.Id;
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            using (var addCustomerForm = new frm_addCustomer())
            {
                addCustomerForm.CustomerUpdated += OnCustomerUpdated;
                addCustomerForm.ShowDialog();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}