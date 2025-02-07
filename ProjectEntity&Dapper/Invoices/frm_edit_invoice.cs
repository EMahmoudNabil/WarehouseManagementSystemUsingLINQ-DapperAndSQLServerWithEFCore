using Microsoft.EntityFrameworkCore;
using ProjectEntity_Dapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjectEntity_Dapper.Invoices
{
    public partial class frm_edit_invoice : Form
    {
        private WarehouseDBContext dbContext;
        private Invoicess currentInvoice;
        private List<InvoiceDetail> invoiceDetails;

        public frm_edit_invoice(string invoiceNumber)
        {
            InitializeComponent();
            dbContext = new WarehouseDBContext();
            LoadInvoiceData(invoiceNumber);
        }

        private void frm_edit_invoice_Load(object sender, EventArgs e)
        {
            var products = dbContext.Products.ToList();
            cmbProducts.DisplayMember = "Name";
            cmbProducts.ValueMember = "Id";
            cmbProducts.DataSource = products;

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "حذف",
                Text = "حذف",
                UseColumnTextForButtonValue = true
            };
            dgv_invoiceItems.Columns.Add(deleteButton);
        }

        private void LoadInvoiceData(string invoiceNumber)
        {
            currentInvoice = dbContext.Invoices
              .Include(i => i.Customer)
              .Include(i => i.InvoiceDetails)
              .ThenInclude(d => d.product)
              .FirstOrDefault(i => i.InvoiceNumber == invoiceNumber);

            if (currentInvoice == null)
            {
                MessageBox.Show("لم يتم العثور على الفاتورة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblNumberInvoice.Text = currentInvoice.InvoiceNumber;
            lblCustomer.Text = currentInvoice.Customer.CustomerName;
            dtpInvoiceDate.Value = currentInvoice.InvoiceDate;

            invoiceDetails = currentInvoice.InvoiceDetails.Select(d => new InvoiceDetail
            {
                InvoiceDetailId = d.InvoiceDetailId,
                InvoiceId = d.InvoiceId,
                ProductId = d.ProductId,
                Quantity = d.Quantity,
                UnitPrice = d.UnitPrice
            }).ToList();

            UpdateGrid();
            UpdateTotalAmount();

            cmbProducts.DataSource = dbContext.Products.ToList();
            cmbProducts.DisplayMember = "Name";
            cmbProducts.ValueMember = "Id";
        }

        private void UpdateTotalAmount()
        {
            decimal totalAmount = invoiceDetails.Sum(d => d.Quantity * d.UnitPrice);
            lblTotalAmount.Text = $"الإجمالي: {totalAmount:C2}";
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedItem is Product selectedProduct && numQuantity.Value > 0)
            {
                var detail = new InvoiceDetail
                {
                    InvoiceId = currentInvoice.InvoiceId,
                    ProductId = selectedProduct.Id,
                    Quantity = (int)numQuantity.Value,
                    UnitPrice = selectedProduct.Price
                };
                invoiceDetails.Add(detail);
                UpdateGrid();
                UpdateTotalAmount();
            }
            else
            {
                MessageBox.Show("يرجى اختيار منتج وتحديد الكمية.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateGrid()
        {
            dgv_invoiceItems.DataSource = null;
            dgv_invoiceItems.DataSource = invoiceDetails.Select(d => new
            {
                d.ProductId,
                ProductName = dbContext.Products.First(p => p.Id == d.ProductId).Name,
                d.Quantity,
                d.UnitPrice,
                TotalPrice = d.Quantity * d.UnitPrice
            }).ToList();
        }

        public event Action<string> OnInvoiceUpdated;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentInvoice == null)
                {
                    MessageBox.Show("الفاتورة غير موجودة!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                currentInvoice.InvoiceDate = dtpInvoiceDate.Value;
                var existingInvoice = dbContext.Invoices
                    .Include(i => i.InvoiceDetails)
                    .FirstOrDefault(i => i.InvoiceId == currentInvoice.InvoiceId);

                if (existingInvoice == null)
                {
                    MessageBox.Show("لم يتم العثور على الفاتورة!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dbContext.InvoiceDetails.RemoveRange(existingInvoice.InvoiceDetails);
                dbContext.SaveChanges();

                foreach (var detail in invoiceDetails)
                {
                    detail.InvoiceDetailId = 0;
                    dbContext.InvoiceDetails.Add(detail);
                }

                dbContext.SaveChanges();
                OnInvoiceUpdated?.Invoke("");

                MessageBox.Show("تم حفظ التعديلات بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_invoiceItems_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_invoiceItems.Columns[e.ColumnIndex].Name == "Delete")
            {
                invoiceDetails.RemoveAt(e.RowIndex);
                UpdateGrid();
                UpdateTotalAmount();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string invoiceNumber = lblCustomer.Text.Trim();

            if (string.IsNullOrEmpty(invoiceNumber))
            {
                MessageBox.Show("رقم الفاتورة غير صحيح أو غير موجود.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("هل تريد حذف هذه الفاتورة؟", "تأكيد الحذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var invoice = dbContext.Invoices
                    .Include(i => i.InvoiceDetails)
                    .FirstOrDefault(i => i.InvoiceNumber == invoiceNumber);

                if (invoice != null)
                {
                    dbContext.InvoiceDetails.RemoveRange(invoice.InvoiceDetails);
                    dbContext.Invoices.Remove(invoice);
                    dbContext.SaveChanges();
                    OnInvoiceUpdated?.Invoke("");
                    MessageBox.Show("تم المسح!", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("لم يتم العثور على الفاتورة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
