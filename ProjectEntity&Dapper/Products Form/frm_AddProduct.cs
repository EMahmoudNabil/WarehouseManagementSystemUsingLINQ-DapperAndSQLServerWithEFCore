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

namespace ProjectEntity_Dapper.Products
{
    public partial class frm_AddProduct : Form
    {
        WarehouseDBContext dBContext;

        string imagePath = "";
        public frm_AddProduct()
        {
            InitializeComponent();
            dBContext = new WarehouseDBContext();
        }

        private void frm_AddProduct_Load(object sender, EventArgs e)
        {

            cmb_category.DataSource = dBContext.Category.ToList();
            cmb_category.DisplayMember = "Name";
            cmb_category.ValueMember = "Id";
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                //validation
                if (string.IsNullOrWhiteSpace(txt_barcode.Text) ||
                    string.IsNullOrWhiteSpace(txt_Productname.Text) ||
                    cmb_category.SelectedValue == null ||
                    num_Price.Value == 0 ||
                    num_Quantity.Value == 0
                    )
                {
                    MessageBox.Show("Please fill all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (pic_product.Image == Image.FromFile(Path.Combine(Environment.CurrentDirectory, "images", "default.png")))
                {
                    MessageBox.Show("Image path is invalid or the image file does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Check is any barcode is the same
                if (dBContext.Products.Any(pr => pr.Code == txt_barcode.Text))
                {
                    MessageBox.Show("A product with the same barcode already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Product p = new Product
                {
                    Code = txt_barcode.Text,
                    Name = txt_Productname.Text,
                    Note = rtxt_discription.Text,
                    Price = num_Price.Value,
                    Quantity = (int)num_Quantity.Value,
                    catid = (int)cmb_category.SelectedValue
                };

                dBContext.Products.Add(p);
                dBContext.SaveChanges();

                // مسار الصورة
                //string newImagePath = Path.Combine(Environment.CurrentDirectory, "images", "Products", p.Id + ".jpg");
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath) &&
                       !imagePath.Contains("default.png"))
                {
                    string newImagePath = Path.Combine(Environment.CurrentDirectory, "images", "Products", p.Id + ".jpg");

                    File.Copy(imagePath, newImagePath, overwrite: true);
                    p.Image = newImagePath;
                }
                else
                {
                    p.Image = null;

                }

                dBContext.SaveChanges();

                MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                ResetForm();


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
            if (open.ShowDialog() == DialogResult.OK)
            {
                imagePath = open.FileName;
                pic_product.ImageLocation = imagePath;
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
