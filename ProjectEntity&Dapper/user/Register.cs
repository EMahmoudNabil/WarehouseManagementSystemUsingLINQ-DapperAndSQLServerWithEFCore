using Microsoft.EntityFrameworkCore;
using ProjectEntity_Dapper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEntity_Dapper.user
{
    public partial class frm_register : Form
    {
        WarehouseDBContext db;
        string imagePath = "";
        public frm_register()
        {
            InitializeComponent();

            db = new WarehouseDBContext();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            try
            {

                string plainPassword = txt_pass.Text;

                string hashedPassword = HashPassword(plainPassword);

                //prod

                //if(db.User.Select())
                User s = new User();

                s.Adress = txt_adress.Text;
                s.Email = txt_email.Text;
                s.Birthday = date_birthdate.Value;
                s.UserName = txt_name.Text;
                s.Password = hashedPassword;
                //s.Image=imagePath;

                db.User.Add(s);
                db.SaveChanges();

                string newimagePath = Environment.CurrentDirectory + "\\images\\Users\\" + s.Id + ".jpg";
                File.Copy(imagePath, newimagePath);
                s.Image = imagePath;
                db.SaveChanges();


                ResetForm();

                //dgv_News.DataSource = bcContext.News.ToList();
                MessageBox.Show($"User {s.UserName} is Added Sucessuflly");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ResetForm()
        {
            txt_adress.Clear();
            txt_name.Clear();
            txt_email.Clear();
            txt_pass.Clear();

            date_birthdate.Value = DateTime.Now;



            imagePath = Path.Combine(Environment.CurrentDirectory, "images", "default1.png");

            if (File.Exists(imagePath))
            {
                pic_box.Image = Image.FromFile(imagePath);
            }
            else
            {
                pic_box.Image = null;
                MessageBox.Show("Default image not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pic_box_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                pic_box.ImageLocation = imagePath;
            }
        }

        //hashing Pasword
        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // تحويل كلمة المرور إلى Byte Array
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                // حساب التشفير
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                // تحويل النتيجة إلى سلسلة نصية
                return Convert.ToBase64String(hashBytes);
            }
        }
        private void frm_register_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
