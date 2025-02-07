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

namespace ProjectEntity_Dapper.user
{

    public partial class frm_profile : Form
    {
        private int UserId;
        WarehouseDBContext db;
        User user;
        string imagePath = "";
        public frm_profile(int id)
        {

            InitializeComponent();
            db = new WarehouseDBContext();
            this.UserId = id;
        }

        private void frm_profile_Load(object sender, EventArgs e)
        {
            user = db.User.Where(n => n.Id == UserId).SingleOrDefault();

            if (user != null)
            {
                txt_username.Text = user.UserName;
                txt_mail.Text = user.Email;
                txt_adress.Text = user.Adress;
                dateTimePicker1.Value = (DateTime)user.Birthday;
                pic_user.ImageLocation = user.Image;


            }

        }

        public event Action<User> UserUpdated;
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {


                if (user != null)
                {
                    
                    user.Email = txt_mail.Text;
                    user.UserName = txt_username.Text;
                    user.Adress = txt_adress.Text;
                    user.Birthday = dateTimePicker1.Value;





                    if (imagePath != "" && File.Exists(imagePath) &&
                        !imagePath.Contains("default1.png"))
                    {
                        string imagesDirectory = Path.Combine(Environment.CurrentDirectory, "images", "Users", user.Id.ToString());
                        File.Copy(imagePath, imagesDirectory, overwrite: true);
                        user.Image = imagesDirectory;


                    }


                    db.SaveChanges();
                    UserUpdated?.Invoke(user);
                    //dgvUserList.DataSource = db.User.ToList();

                    MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();

                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ResetForm()
        {
            txt_username.Clear();
            txt_mail.Clear();
            txt_adress.Clear();
            dateTimePicker1.Value = DateTime.Now;



            imagePath = Path.Combine(Environment.CurrentDirectory, "images", "default1.png");

            if (File.Exists(imagePath))
            {
                pic_user.Image = Image.FromFile(imagePath);
            }
            else
            {
                pic_user.Image = null;
                MessageBox.Show("Default image not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pic_user_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                imagePath = open.FileName;
                pic_user.ImageLocation = imagePath;
            }
        }

        private void pic_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_changePassword frm_ChangePassword = new frm_changePassword(UserId);
            frm_ChangePassword.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
