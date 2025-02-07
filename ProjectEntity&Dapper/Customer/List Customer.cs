using Microsoft.EntityFrameworkCore;
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

namespace ProjectEntity_Dapper.Customer
{
    public partial class frm_listCustomer : Form
    {

        WarehouseDBContext dbContext;
        int id;
        Customers customer;
        public frm_listCustomer()
        {
            InitializeComponent();
            dbContext = new WarehouseDBContext();
        }

        private void frm_listCustomer_Load(object sender, EventArgs e)
        {
            dgvCustomerList.DataSource = dbContext.Customer.ToList();
            dgvCustomerList.Columns["Id"].Visible = false;
            dgvCustomerList.Columns["isActive"].Visible = false;
        }

        private void pic_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_refrsh_Click(object sender, EventArgs e)
        {
            dgvCustomerList.DataSource = dbContext.Customer.ToList();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (txt_search.Text != "")
            {
                var searchword = dbContext.Customer.Where(b => b.PhoneNumber == txt_search.Text || b.CustomerName.Contains(txt_search.Text)).ToList();
                dgvCustomerList.DataSource = searchword;
            }
            else
            {
                dgvCustomerList.DataSource = dbContext.Products.ToList();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                customer = dbContext.Customer.Where(x => x.Id == id).SingleOrDefault();
                if (customer != null)
                {
                    dbContext.Customer.Remove(customer);
                    dbContext.SaveChanges();
                    ResetForm();
                    dgvCustomerList.DataSource = dbContext.Customer.ToList();
                    MessageBox.Show("Customer record deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Customer not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                customer = dbContext.Customer.Where(x => x.Id == id).SingleOrDefault();

                if (customer != null)
                {

                    customer.Address = txt_Address.Text;
                    customer.City = txt_City.Text;
                    customer.Country = txt_Country.Text;
                    customer.Email = txt_Email.Text;
                    customer.CustomerName = txt_name.Text;
                    customer.PhoneNumber = txt_phone.Text;
                    customer.Notes = rtxt_discription.Text;







                    dbContext.SaveChanges();

                    dgvCustomerList.DataSource = dbContext.Customer.ToList();

                    MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                    btn_save.Enabled = false; 
                    btn_delete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCustomerList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = (int)dgvCustomerList.SelectedRows[0].Cells[0].Value;

                customer = dbContext.Customer.Where(n => n.Id == id).SingleOrDefault();
                if (customer != null)
                {



                    txt_Address.Text = customer.Address;
                    txt_City.Text = customer.City;
                    txt_Country.Text = customer.Country;
                    txt_Email.Text = customer.Email;
                    txt_name.Text = customer.CustomerName;
                    txt_phone.Text = customer.PhoneNumber;
                    rtxt_discription.Text = customer.Notes;



                    btn_save.Enabled = true;
                    btn_delete.Enabled = true;

                }
            }
        }
        private void ResetForm()
        {
            txt_Address.Clear();
            txt_City.Clear();
            txt_Country.Clear();
            txt_Email.Clear();
            txt_name.Clear();
            txt_phone.Clear();
            rtxt_discription.Clear();



        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
