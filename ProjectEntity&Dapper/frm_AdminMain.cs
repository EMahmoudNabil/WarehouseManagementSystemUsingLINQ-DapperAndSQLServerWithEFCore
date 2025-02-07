using ProjectEntity_Dapper.Customer;
using ProjectEntity_Dapper.Invoice;
using ProjectEntity_Dapper.Invoices;
using ProjectEntity_Dapper.Models;
using ProjectEntity_Dapper.Products;
using ProjectEntity_Dapper.Products_Form;
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
    public partial class frm_AdminMain : Form
    {

        WarehouseDBContext db;
        User user;
        private int UserId;
        private string Username;
        private string Image;
        private string Role;
        public frm_AdminMain(int id, string username, string image, string role)
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


    

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_register re = new frm_register();
            re.Show();


        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            frm_register re = new frm_register();
            re.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AddProduct re = new frm_AddProduct();
            re.Show();
        }

        private void listProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_productList re = new frm_productList();
            re.Show();
        }

        private void liToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_userList re = new frm_userList();
            re.Show();
        }

        private void frm_main_Load(object sender, EventArgs e)
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

        private void pic_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();

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

        private void btn_customers_Click(object sender, EventArgs e)
        {
            frm_addCustomer fr = new frm_addCustomer();
            fr.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_addCustomer addCustomer = new frm_addCustomer();
            addCustomer.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frm_listCustomer frm_ListCustomer = new frm_listCustomer();
            frm_ListCustomer.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_add_Invoice fr = new frm_add_Invoice();
            fr.Show();
        }

        private void listInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_invoiceList fr = new frm_invoiceList();
            fr.Show();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            frm_AddProduct frm = new frm_AddProduct();
            frm.Show();
        }

        private void btn_suplier_Click(object sender, EventArgs e)
        {
            frm_add_Invoice frm = new frm_add_Invoice();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        private void manageCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_category fr =new frm_category();
            fr.Show();
        }
    }
}
