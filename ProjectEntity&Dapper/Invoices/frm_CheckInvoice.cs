using ProjectEntity_Dapper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEntity_Dapper.Invoices
{
    public partial class frm_CheckInvoice : Form
    {
        private WarehouseDBContext dbContext;
        public frm_CheckInvoice()
        {
            InitializeComponent();
            dbContext = new WarehouseDBContext();
        }

        private void btn_CheckInvoice_Click(object sender, EventArgs e)
        {
            //string invoiceNumber = txt_InvoiceNumber.Text.Trim();

            //if (string.IsNullOrEmpty(invoiceNumber))
            //{
            //    MessageBox.Show("Please enter an invoice number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //var invoice = dbContext.Invoices.FirstOrDefault(i => i.InvoiceNumber == invoiceNumber);

            //if (invoice != null)
            //{
            //    // فتح نموذج تفاصيل الفاتورة وتمرير رقم الفاتورة
            //    frm_InvoiceDetails invoiceDetailsForm = new frm_InvoiceDetails(invoice.InvoiceNumber);
            //    invoiceDetailsForm.Show();
            //    this.Hide(); // إخفاء الفورم الحالي
            //}
            //else
            //{
            //    MessageBox.Show("Invoice not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_InvoiceNumber_Click(object sender, EventArgs e)
        {
            txt_InvoiceNumber.Text = "INV-";
        }
    }
}
