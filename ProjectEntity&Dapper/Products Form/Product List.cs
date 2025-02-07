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

namespace ProjectEntity_Dapper.Products_Form
{
    public partial class frm_productList : Form
    {
        WarehouseDBContext dbContext;
        string imagePath = "";
        Product p;
        public frm_productList()
        {
            InitializeComponent();
            dbContext = new WarehouseDBContext();
            p = new Product();
        }

        private void frm_productList_Load(object sender, EventArgs e)
        {

            dgvProductList.DataSource = dbContext.Products.ToList();
            dgvProductList.Columns["Id"].Visible = false;
            dgvProductList.Columns["Image"].Visible = false;
            dgvProductList.Columns["Note"].Visible = false;
            dgvProductList.Columns["catid"].Visible = false;

            cmb_category.DataSource = dbContext.Category.ToList();
            cmb_category.DisplayMember = "Name";
            cmb_category.ValueMember = "Id";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Create_Click(object sender, EventArgs e)
        {

            if (txt_search.Text != "")
            {
                var searchword = dbContext.Products.Where(b => b.Code == txt_search.Text || b.Name.Contains(txt_search.Text)).ToList();
                dgvProductList.DataSource = searchword;
            }
            else
            {
                dgvProductList.DataSource = dbContext.Products.ToList();
            }
        }

        private void btn_refrsh_Click(object sender, EventArgs e)
        {
            dgvProductList.DataSource = dbContext.Products.ToList();
        }
        int id;
        private void dgvProductList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = (int)dgvProductList.SelectedRows[0].Cells[0].Value;

                p = dbContext.Products.Where(n => n.Id == id).SingleOrDefault();
                if (p != null)
                {
                    txt_barcode.Text = p.Code;
                    txt_Productname.Text = p.Name;
                    rtxt_discription.Text = p.Note;
                    num_Price.Value = p.Price;
                    num_Quantity.Value = p.Quantity;
                    cmb_category.SelectedValue = p.catid;
                    pic_product.ImageLocation = p.Image;

                    btn_save.Enabled = true;
                    btn_delete.Enabled = true;
        
                }
            }


        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                p = dbContext.Products.Where(x => x.Id == id).SingleOrDefault();

                if (p != null)
                {
                    p.Code = txt_barcode.Text;
                    p.Name = txt_Productname.Text;
                    p.Note = rtxt_discription.Text;
                    p.Price = num_Price.Value;
                    p.Quantity = (int)num_Quantity.Value;
                    if (cmb_category.SelectedValue != null)
                    {
                        p.catid = (int)cmb_category.SelectedValue;
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    if (imagePath != "" && File.Exists(imagePath) &&
                        !imagePath.Contains("default.png"))
                    {
                        string imagesDirectory = Path.Combine(Environment.CurrentDirectory, "images", "Products", p.Id.ToString());
                        File.Copy(imagePath, imagesDirectory, overwrite: true);
                        p.Image = imagesDirectory;


                    }


                    dbContext.SaveChanges();

                    dgvProductList.DataSource = dbContext.Products.ToList();

                    MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                    btn_save.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ResetForm()
        {
            txt_barcode.Clear();
            txt_Productname.Clear();
            rtxt_discription.Clear();
            num_Price.Value = 0;
            num_Quantity.Value = 1;
            cmb_category.SelectedIndex = -1;

            // إعداد الصورة الافتراضية
            imagePath = Path.Combine(Environment.CurrentDirectory, "images", "default.png");

            if (File.Exists(imagePath))
            {
                pic_product.Image = Image.FromFile(imagePath);
            }
            else
            {
                pic_product.Image = null;
                MessageBox.Show("Default image not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pic_product_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; // تصفية الملفات المسموح باختيارها
            if (open.ShowDialog() == DialogResult.OK)
            {
                imagePath = open.FileName; // تخزين المسار المحدد
                pic_product.ImageLocation = imagePath; // عرض الصورة في الـ PictureBox
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                p = dbContext.Products.Where(x => x.Id == id).SingleOrDefault();
                if (p != null)
                {
                    dbContext.Products.Remove(p);
                    dbContext.SaveChanges();
                    ResetForm();
                    dgvProductList.DataSource = dbContext.Products.ToList();
                    MessageBox.Show("Product record deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void pic_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


