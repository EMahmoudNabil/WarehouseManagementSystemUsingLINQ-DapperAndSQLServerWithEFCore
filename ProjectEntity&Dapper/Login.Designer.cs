using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProjectEntity_Dapper
{
    partial class frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            txt_name = new TextBox();
            lbl_username = new Label();
            txt_Pass = new TextBox();
            lbl_password = new Label();
            btn_back = new Button();
            btn_Login = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            pictureBox2 = new PictureBox();
            chk_password = new CheckBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_name.Location = new Point(582, 227);
            txt_name.MaximumSize = new Size(340, 50);
            txt_name.MinimumSize = new Size(340, 35);
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = "Write User Name ......";
            txt_name.Size = new Size(340, 35);
            txt_name.TabIndex = 1;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI Semibold", 14F);
            lbl_username.ForeColor = Color.White;
            lbl_username.Location = new Point(582, 199);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(107, 25);
            lbl_username.TabIndex = 9;
            lbl_username.Text = "User Name";
            // 
            // txt_Pass
            // 
            txt_Pass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Pass.Location = new Point(582, 321);
            txt_Pass.MaximumSize = new Size(340, 50);
            txt_Pass.MaxLength = 15;
            txt_Pass.MinimumSize = new Size(340, 35);
            txt_Pass.Name = "txt_Pass";
            txt_Pass.PasswordChar = '*';
            txt_Pass.PlaceholderText = "*******************";
            txt_Pass.Size = new Size(340, 35);
            txt_Pass.TabIndex = 2;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI Semibold", 14F);
            lbl_password.ForeColor = Color.White;
            lbl_password.Location = new Point(582, 293);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(91, 25);
            lbl_password.TabIndex = 11;
            lbl_password.Text = "Password";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(64, 64, 64);
            btn_back.Cursor = Cursors.Hand;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.ForeColor = SystemColors.ButtonFace;
            btn_back.Image = Properties.Resources.icons8_back_50;
            btn_back.ImageAlign = ContentAlignment.MiddleLeft;
            btn_back.Location = new Point(586, 426);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(146, 54);
            btn_back.TabIndex = 5;
            btn_back.Text = "Close";
            btn_back.TextAlign = ContentAlignment.MiddleRight;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.FromArgb(0, 64, 64);
            btn_Login.BackgroundImageLayout = ImageLayout.None;
            btn_Login.Cursor = Cursors.Hand;
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Login.ForeColor = SystemColors.ButtonFace;
            btn_Login.Image = Properties.Resources.icons8_login_50;
            btn_Login.ImageAlign = ContentAlignment.MiddleRight;
            btn_Login.Location = new Point(757, 426);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(165, 54);
            btn_Login.TabIndex = 4;
            btn_Login.Text = "Login";
            btn_Login.TextAlign = ContentAlignment.MiddleLeft;
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(576, 555);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(582, 83);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 16;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(586, 126);
            label2.Name = "label2";
            label2.Size = new Size(230, 13);
            label2.TabIndex = 17;
            label2.Text = "Welecome To Warehouse Application Login";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_close_48;
            pictureBox2.Location = new Point(917, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // chk_password
            // 
            chk_password.AutoSize = true;
            chk_password.ForeColor = Color.White;
            chk_password.Location = new Point(586, 372);
            chk_password.Name = "chk_password";
            chk_password.Size = new Size(108, 19);
            chk_password.TabIndex = 3;
            chk_password.Text = "Show Password";
            chk_password.UseVisualStyleBackColor = true;
            chk_password.CheckedChanged += chk_password_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(617, 492);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(270, 15);
            linkLabel1.TabIndex = 19;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "If you haven`t accout you can click to registration ";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(968, 528);
            Controls.Add(linkLabel1);
            Controls.Add(chk_password);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btn_back);
            Controls.Add(btn_Login);
            Controls.Add(txt_Pass);
            Controls.Add(lbl_password);
            Controls.Add(txt_name);
            Controls.Add(lbl_username);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name;
        private Label lbl_username;
        private TextBox txt_Pass;
        private Label lbl_password;
        private Button btn_back;
        private Button btn_Login;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private PictureBox pictureBox2;
        private CheckBox chk_password;
        private LinkLabel linkLabel1;
    }
}
