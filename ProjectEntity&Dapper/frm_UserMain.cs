using ProjectEntity_Dapper.Customer;
using ProjectEntity_Dapper.Invoice;
using ProjectEntity_Dapper.Models;
using ProjectEntity_Dapper.Products;
using ProjectEntity_Dapper.user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectEntity_Dapper
{
    public partial class frm_UserMain : Form
    {

        WarehouseDBContext db;
        User user;
        private int UserId;
        private string Username;
        private string Image;
        private string Role;
        public frm_UserMain(int id, string username, string image, string role)
        {
            InitializeComponent();
            db = new WarehouseDBContext();
            user = new User();
            this.UserId = id;
            this.Username = username;
            this.Role = role;
            this.Image = image;
            //LoadUIBasedOnRole();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            frm_AddProduct frm_AddProduct = new frm_AddProduct();
            frm_AddProduct.ShowDialog();
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            frm_addCustomer frm_AddCustomer = new frm_addCustomer();
            frm_AddCustomer.ShowDialog();
        }

        private void btn_suplier_Click(object sender, EventArgs e)
        {
            frm_add_Invoice add_Invoice = new frm_add_Invoice();
            add_Invoice.ShowDialog();
        }

        private void frm_UserMain_Load(object sender, EventArgs e)
        {
            lbl_uername.Text = "Welcome, " + Username;
            if (Image != null)
            {
                pic_profile.ImageLocation = Image;
            }
            else
            {

            }
        }

        private void pic_profile_Click(object sender, EventArgs e)
        {
            frm_profile profile = new frm_profile(UserId);
            profile.UserUpdated += OnUserUpdated;
            profile.Show();
        }

        private void OnUserUpdated(User updatedUser)
        {

            Username = updatedUser.UserName;
            Image = updatedUser.Image;

            lbl_uername.Text = "Welcome, " + Username;

            if (!string.IsNullOrWhiteSpace(Image) && System.IO.File.Exists(Image))
            {
                pic_profile.ImageLocation = Image;
            }
            else
            {
                pic_profile.Image = null; 
            }
        }

        private void pic_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }
    }
}
