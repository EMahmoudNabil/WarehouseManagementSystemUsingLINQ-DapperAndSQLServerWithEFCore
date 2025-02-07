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
    public partial class frm_addCustomer : Form
    {

        WarehouseDBContext dbContext;
        public frm_addCustomer()
        {
            InitializeComponent();
            dbContext = new WarehouseDBContext();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event Action<Customers> CustomerUpdated;
        private void btn_Create_Click(object sender, EventArgs e)
        {

            try
            {
                //validation
                if (string.IsNullOrWhiteSpace(txt_Address.Text) ||
                    string.IsNullOrWhiteSpace(txt_City.Text) ||
                    string.IsNullOrWhiteSpace(txt_Country.Text) ||
                    string.IsNullOrWhiteSpace(txt_Email.Text) ||
                    string.IsNullOrWhiteSpace(txt_name.Text) ||
                    string.IsNullOrWhiteSpace(txt_phone.Text) 


                    )
                {
                    MessageBox.Show("Please fill all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               

                //Check is any barcode is the same
                if (dbContext.Customer.Any(pr => pr.PhoneNumber == txt_phone.Text || pr.Email==txt_Email.Text) )
                {
                    MessageBox.Show("A Customer barcode already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Customers cust = new Customers();
                cust.Address = txt_Address.Text;
                cust.City = txt_City.Text;
                cust.Country = txt_Country.Text;
                cust.Email = txt_Email.Text;
                cust.CustomerName= txt_name.Text;
                cust.PhoneNumber= txt_phone.Text;
                cust.Notes=rtxt_discription.Text;




                dbContext.Customer.Add(cust);
                dbContext.SaveChanges();


                CustomerUpdated?.Invoke(cust);
                MessageBox.Show("Customer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                ResetForm();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
