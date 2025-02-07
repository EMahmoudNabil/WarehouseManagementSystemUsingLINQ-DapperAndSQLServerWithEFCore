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
    public partial class frm_userList : Form
    {
        WarehouseDBContext dbContext;
        User num;
        string imagePath = "";
        public frm_userList()
        {
            InitializeComponent();
            dbContext = new WarehouseDBContext();
            num = new User();
        }

        private void pic_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void List_User_Load(object sender, EventArgs e)
        {
            dgvUserList.DataSource = dbContext.User.ToList();
            dgvUserList.Columns["Password"].Visible = false; 
            dgvUserList.Columns["Image"].Visible = false;
            dgvUserList.Columns["Id"].Visible = false;
            //cmbo_role.DataSource = dbContext.User.ToList();
            //cmbo_role.DisplayMember = "Role";
            //cmbo_role.ValueMember = "Id";
        }

        private void btn_refrsh_Click(object sender, EventArgs e)
        {
            dgvUserList.DataSource = dbContext.User.ToList();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (txt_search.Text != "")
            {

                var searchWord = dbContext.User.Where(x => x.UserName.Contains(txt_search.Text));
                dgvUserList.DataSource = searchWord.ToList();
            }
        }

        int id;
        private void dgvUserList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgvUserList.SelectedRows[0].Cells[0].Value;

            num = dbContext.User.Where(n => n.Id == id).SingleOrDefault();
            if (num != null)
            {
                txt_username.Text = num.UserName;
                txt_mail.Text = num.Email;
                //txt_adress.Text = num.Adress;
                //dateTimePicker1.Value = (DateTime)num.Birthday;
                //pic_user.ImageLocation = num.Image;
                cmbo_role.SelectedItem = num.Role;



                btn_save.Enabled = true;
                btn_delete.Enabled = true;
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
                num = dbContext.User.Where(x => x.Id == id).SingleOrDefault();

                if (num != null)
                {
                    // تحديث بيانات المنتج
                    num.Email = txt_mail.Text;
                    num.UserName = txt_username.Text;
                    //num.Adress = txt_adress.Text;
                    //num.Birthday = dateTimePicker1.Value;
                    num.Role = cmbo_role.SelectedItem.ToString();




                    //if (imagePath != "" && File.Exists(imagePath) &&
                    //    !imagePath.Contains("default1.png"))
                    //{
                    //    string imagesDirectory = Path.Combine(Environment.CurrentDirectory, "images", "Users", num.Id.ToString());
                    //    File.Copy(imagePath, imagesDirectory, overwrite: true);
                    //    num.Image = imagesDirectory;


                    //}


                    dbContext.SaveChanges();

                    dgvUserList.DataSource = dbContext.User.ToList();

                    MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                    btn_save.Enabled = false;
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
            //txt_adress.Clear();
            //dateTimePicker1.Value = DateTime.Now;



            //imagePath = Path.Combine(Environment.CurrentDirectory, "images", "default1.png");

            //if (File.Exists(imagePath))
            //{
            //    pic_user.Image = Image.FromFile(imagePath);
            //}
            //else
            //{
            //    pic_user.Image = null;
            //    MessageBox.Show("Default image not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                num = dbContext.User.Where(x => x.Id == id).SingleOrDefault();
                if (num != null)
                {
                    var confirmation = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmation == DialogResult.Yes)
                    {
                        dbContext.User.Remove(num);
                        dbContext.SaveChanges();
                        ResetForm();
                        dgvUserList.DataSource = dbContext.User.ToList();
                        MessageBox.Show("Users record deleted successfully.");
                    }
                }
                else
                {
                    MessageBox.Show("Users not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        //private void pic_user_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog open = new OpenFileDialog();
        //    if (open.ShowDialog() == DialogResult.OK)
        //    {
        //        imagePath = open.FileName;
        //        pic_user.ImageLocation = imagePath;
        //    }
        //}

        private void dgvUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
