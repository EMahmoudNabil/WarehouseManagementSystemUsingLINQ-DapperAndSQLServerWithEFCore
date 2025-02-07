using ProjectEntity_Dapper.Models;
using ProjectEntity_Dapper.user;
using System.Security.Cryptography;
using System.Text;

namespace ProjectEntity_Dapper
{
    public partial class frm_Login : Form
    {

        WarehouseDBContext dBContext;

        public frm_Login()
        {
            InitializeComponent();
            dBContext = new WarehouseDBContext();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            //string enteredUsername = txt_name.Text;
            //string enteredPassword = txt_Pass.Text;

            //string hashedEnteredPassword = HashPassword(enteredPassword);

            //var user = dBContext.User.Where(x => x.UserName == enteredUsername && x.Password == hashedEnteredPassword);

            //if (user != null)
            //{
            //    this.Hide();
            //    Thread th = new Thread(open_form);
            //    th.SetApartmentState(ApartmentState.STA);
            //    th.Start();
            //}
            //else
            //{
            //    MessageBox.Show("UserName Or Password has wrong");
            //}

            string enteredUsername = txt_name.Text;
            string enteredPassword = txt_Pass.Text;

            // Ensure the HashPassword function exists and works correctly
            string hashedEnteredPassword = HashPassword(enteredPassword);

            // Search for the user in the database
            var user1 = dBContext.User.Where(x => x.UserName == enteredUsername && x.Password == hashedEnteredPassword);

            if (user1 != null)
            {
                this.Hide(); // Hide the login form
                var user = dBContext.User.FirstOrDefault(x => x.UserName == txt_name.Text);
                // Open the appropriate form based on the user's role
                if (user?.Role == "Admin")
                {

                    // frm_AdminMain frm_AdminMain = new frm_AdminMain(user.Id, user.UserName, user.Image, user.Role);
                    //frm_AdminMain.ShowDialog();  
                    Thread th = new Thread(() => Application.Run(new frm_AdminMain(user.Id, user.UserName, user.Image, user.Role)));
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else if (user?.Role == "User")
                {
                    //frm_UserMain frm_UserMain = new frm_UserMain(user.Id, user.UserName, user.Image, user.Role);
                    //frm_UserMain.ShowDialog();
                    Thread th = new Thread(() => Application.Run(new frm_UserMain(user.Id, user.UserName, user.Image, user.Role)));
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("Unknown role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);

                byte[] hashBytes = sha256.ComputeHash(bytes);

                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
        //void open_form()
        //{
        //    var user1 = dBContext.User.FirstOrDefault(x => x.UserName == txt_name.Text);
        //    Application.Run(new frm_AdminMain(user1.Id,user1.UserName ,user1.Image , user1.Role));
        //}

        private void chk_password_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_password.Checked)
            {
                txt_Pass.PasswordChar = '\0';
            }
            else
            {
                txt_Pass.PasswordChar = '*';
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_register frm_Register = new frm_register(); 
            frm_Register.ShowDialog();
        }
    }
}
