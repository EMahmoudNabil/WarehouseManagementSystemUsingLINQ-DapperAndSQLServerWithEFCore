namespace ProjectEntity_Dapper.user
{
    partial class frm_profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_profile));
            dateTimePicker1 = new DateTimePicker();
            txt_adress = new TextBox();
            btn_back = new Button();
            btn_save = new Button();
            label3 = new Label();
            pic_user = new PictureBox();
            txt_username = new TextBox();
            label4 = new Label();
            lbl_birthday = new Label();
            lbl_Adress = new Label();
            txt_mail = new TextBox();
            lbl_ProdName = new Label();
            pic_Close = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pic_user).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.Gray;
            dateTimePicker1.CalendarTitleForeColor = SystemColors.ControlDarkDark;
            dateTimePicker1.Font = new Font("Segoe UI", 12F);
            dateTimePicker1.Location = new Point(589, 271);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(240, 29);
            dateTimePicker1.TabIndex = 4;
            // 
            // txt_adress
            // 
            txt_adress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_adress.Location = new Point(589, 210);
            txt_adress.MaximumSize = new Size(240, 50);
            txt_adress.MinimumSize = new Size(240, 35);
            txt_adress.Name = "txt_adress";
            txt_adress.PlaceholderText = "Write Adress Here......";
            txt_adress.Size = new Size(240, 35);
            txt_adress.TabIndex = 3;
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
            btn_back.Location = new Point(555, 489);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(129, 50);
            btn_back.TabIndex = 6;
            btn_back.Text = "Back";
            btn_back.TextAlign = ContentAlignment.MiddleRight;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(0, 64, 64);
            btn_save.Cursor = Cursors.Hand;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.ForeColor = SystemColors.ButtonFace;
            btn_save.Image = Properties.Resources.icons8_update_50;
            btn_save.ImageAlign = ContentAlignment.MiddleRight;
            btn_save.Location = new Point(690, 488);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(139, 52);
            btn_save.TabIndex = 5;
            btn_save.Text = "Save";
            btn_save.TextAlign = ContentAlignment.MiddleLeft;
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(439, 400);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 69;
            label3.Text = "Image User";
            // 
            // pic_user
            // 
            pic_user.Cursor = Cursors.Hand;
            pic_user.Image = Properties.Resources.pngwing_com12;
            pic_user.Location = new Point(589, 347);
            pic_user.Name = "pic_user";
            pic_user.Size = new Size(240, 127);
            pic_user.SizeMode = PictureBoxSizeMode.Zoom;
            pic_user.TabIndex = 68;
            pic_user.TabStop = false;
            pic_user.Click += pic_user_Click;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(589, 147);
            txt_username.MaximumSize = new Size(240, 50);
            txt_username.MinimumSize = new Size(240, 35);
            txt_username.Name = "txt_username";
            txt_username.PlaceholderText = "Write User Name Here......";
            txt_username.Size = new Size(240, 35);
            txt_username.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(442, 150);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 67;
            label4.Text = "User Name";
            // 
            // lbl_birthday
            // 
            lbl_birthday.AutoSize = true;
            lbl_birthday.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_birthday.ForeColor = Color.White;
            lbl_birthday.Location = new Point(442, 277);
            lbl_birthday.Name = "lbl_birthday";
            lbl_birthday.Size = new Size(71, 21);
            lbl_birthday.TabIndex = 66;
            lbl_birthday.Text = "Birthday";
            // 
            // lbl_Adress
            // 
            lbl_Adress.AutoSize = true;
            lbl_Adress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Adress.ForeColor = Color.White;
            lbl_Adress.Location = new Point(442, 210);
            lbl_Adress.Name = "lbl_Adress";
            lbl_Adress.Size = new Size(60, 21);
            lbl_Adress.TabIndex = 65;
            lbl_Adress.Text = "Adress";
            // 
            // txt_mail
            // 
            txt_mail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_mail.Location = new Point(589, 85);
            txt_mail.MaximumSize = new Size(240, 50);
            txt_mail.MinimumSize = new Size(240, 35);
            txt_mail.Name = "txt_mail";
            txt_mail.PlaceholderText = "Write Email Here......";
            txt_mail.Size = new Size(240, 35);
            txt_mail.TabIndex = 1;
            // 
            // lbl_ProdName
            // 
            lbl_ProdName.AutoSize = true;
            lbl_ProdName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ProdName.ForeColor = Color.White;
            lbl_ProdName.Location = new Point(438, 88);
            lbl_ProdName.Name = "lbl_ProdName";
            lbl_ProdName.Size = new Size(48, 21);
            lbl_ProdName.TabIndex = 64;
            lbl_ProdName.Text = "Email";
            // 
            // pic_Close
            // 
            pic_Close.Image = Properties.Resources.icons8_close_48;
            pic_Close.Location = new Point(835, 12);
            pic_Close.Name = "pic_Close";
            pic_Close.Size = new Size(35, 35);
            pic_Close.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Close.TabIndex = 75;
            pic_Close.TabStop = false;
            pic_Close.Click += pic_Close_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._3456388;
            pictureBox1.Location = new Point(23, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 324);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 76;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 15);
            label2.Name = "label2";
            label2.Size = new Size(84, 32);
            label2.TabIndex = 77;
            label2.Text = "Profile";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(24, 478);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(316, 21);
            linkLabel1.TabIndex = 78;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Click here when you need Change password";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // frm_profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(886, 553);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(pic_Close);
            Controls.Add(dateTimePicker1);
            Controls.Add(txt_adress);
            Controls.Add(btn_back);
            Controls.Add(btn_save);
            Controls.Add(label3);
            Controls.Add(pic_user);
            Controls.Add(txt_username);
            Controls.Add(label4);
            Controls.Add(lbl_birthday);
            Controls.Add(lbl_Adress);
            Controls.Add(txt_mail);
            Controls.Add(lbl_ProdName);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Profiledata";
            Load += frm_profile_Load;
            ((System.ComponentModel.ISupportInitialize)pic_user).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private TextBox txt_adress;
        private Button btn_back;
        private Button btn_save;
        private Label label3;
        private PictureBox pic_user;
        private TextBox txt_username;
        private Label label4;
        private Label lbl_birthday;
        private Label lbl_Adress;
        private TextBox txt_mail;
        private Label lbl_ProdName;
        private PictureBox pic_Close;
        private PictureBox pictureBox1;
        private Label label2;
        private LinkLabel linkLabel1;
    }
}