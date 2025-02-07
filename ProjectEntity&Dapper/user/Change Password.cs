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
    public partial class frm_changePassword : Form
    {
        private int UserId;
        WarehouseDBContext dbContext;

        public frm_changePassword(int userId)
        {
            InitializeComponent();
            this.UserId = userId;
            dbContext = new WarehouseDBContext();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                string enteredOldPassword = txtOldPassword.Text;

                string newPassword = txtNewPassword.Text;        
                string confirmNewPassword = txtConfirmPassword.Text;
                Console.WriteLine($"Original Entered Password: {enteredOldPassword}");
                string hashedEnteredOldPassword = HashPassword(enteredOldPassword);
                Console.WriteLine($"Hashed Entered Old Password: {hashedEnteredOldPassword}");



                var user = dbContext.User.Where(n => n.Id == UserId).SingleOrDefault();
                Console.WriteLine($"Stored Password in DB: {user.Password}");
                if (user != null)
                {
                    Console.WriteLine($"Old Hashed Password in DB: {user.Password}");
                    Console.WriteLine($"Entered Old Hashed Password: {hashedEnteredOldPassword}");

                    if (user.Password == hashedEnteredOldPassword)
                    {
                        if (newPassword == confirmNewPassword)
                        {
                            user.Password = HashPassword(newPassword);

                            dbContext.SaveChanges();
                            MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtOldPassword.Clear();
                            txtNewPassword.Clear();
                            txtConfirmPassword.Clear();
                        }
                        else
                        {
                            MessageBox.Show("New password and confirmation do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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

        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                return Convert.ToBase64String(hashBytes);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
