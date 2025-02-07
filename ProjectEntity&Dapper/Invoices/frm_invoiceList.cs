using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.EntityFrameworkCore;
using ProjectEntity_Dapper.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjectEntity_Dapper.Invoices
{
    public partial class frm_invoiceList : Form
    {
        public frm_invoiceList()
        {
            InitializeComponent();
            dbContext = new WarehouseDBContext();
            LoadInvoices();
            InitializeDataGridView();
        }

        // Load invoices and calculate the total amount
        private void LoadInvoices(string searchText = "")
        {
            dgvInvoices.DataSource = null;
            var invoices = dbContext.Invoices
                .Where(i => i.InvoiceNumber.Contains(searchText))
                .Include(i => i.Customer)
                .ToList();

            dgvInvoices.DataSource = invoices.Select(i => new
            {
                i.InvoiceNumber,
                i.Customer.CustomerName,
                i.InvoiceDate,
                TotalAmount = i.InvoiceDetails.Sum(d => d.Quantity * d.UnitPrice)
            }).ToList();
            dgvInvoices.Refresh();
        }

        // Handle click events for "Edit" and "Delete" columns
        private void dgvInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string invoiceNumber = dgvInvoices.Rows[e.RowIndex].Cells["InvoiceNumber"].Value.ToString();

                // Check if the column is "Edit"
                if (e.ColumnIndex == dgvInvoices.Columns["Edit"].Index)
                {
                    frm_edit_invoice editForm = new frm_edit_invoice(invoiceNumber);

                    // Subscribe to the OnInvoiceUpdated event to listen for invoice updates
                    editForm.OnInvoiceUpdated += (searchText) => LoadInvoices(searchText);

                    editForm.Show(); // Show the form as a dialog
                }

                // Check if the column is "Delete"
                else if (e.ColumnIndex == dgvInvoices.Columns["Delete"].Index)
                {
                    if (MessageBox.Show("Do you want to delete this invoice?", "Delete Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var invoice = dbContext.Invoices
                            .Include(i => i.InvoiceDetails)
                            .FirstOrDefault(i => i.InvoiceNumber == invoiceNumber);

                        if (invoice != null)
                        {
                            dbContext.InvoiceDetails.RemoveRange(invoice.InvoiceDetails);
                            dbContext.Invoices.Remove(invoice);
                            dbContext.SaveChanges();
                            LoadInvoices(); // Reload invoices after deletion
                        }
                    }
                }
            }
        }

        // Initialize "Edit" and "Delete" columns
        private void InitializeDataGridView()
        {
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn
            {
                Name = "Edit",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            dgvInvoices.Columns.Add(editButton);

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            dgvInvoices.Columns.Add(deleteButton);
        }

        // Export invoices to PDF
        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToPDF(saveFileDialog.FileName);
                }
            }
        }

        // Export invoices to a PDF file
        private void ExportToPDF(string filePath)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            document.Add(new Paragraph("Invoice List\n\n"));
            PdfPTable table = new PdfPTable(4);
            table.AddCell("Invoice Number");
            table.AddCell("Customer Name");
            table.AddCell("Date");
            table.AddCell("Amount");

            foreach (DataGridViewRow row in dgvInvoices.Rows)
            {
                table.AddCell(row.Cells["InvoiceNumber"].Value.ToString());
                table.AddCell(row.Cells["CustomerName"].Value.ToString());
                table.AddCell(row.Cells["InvoiceDate"].Value.ToString());
                table.AddCell(row.Cells["TotalAmount"].Value.ToString());
            }

            document.Add(table);
            document.Close();

            MessageBox.Show("Invoices have been successfully exported to PDF.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frm_invoiceList_Load(object sender, EventArgs e)
        {
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            LoadInvoices(searchText);
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
