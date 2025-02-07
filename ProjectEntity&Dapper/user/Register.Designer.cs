using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProjectEntity_Dapper.user
{
    partial class frm_register
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_register));
            lbl_Name = new Label();
            lbl_email = new Label();
            lbl_pass = new Label();
            lbl_Age = new Label();
            lbl_Adress = new Label();
            txt_name = new TextBox();
            txt_adress = new TextBox();
            txt_email = new TextBox();
            txt_pass = new TextBox();
            btn_Submit = new Button();
            btn_back = new Button();
            pic_box = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            date_birthdate = new DateTimePicker();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Name.ForeColor = Color.White;
            lbl_Name.Location = new Point(34, 97);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(90, 21);
            lbl_Name.TabIndex = 3;
            lbl_Name.Text = "User Name";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_email.ForeColor = Color.White;
            lbl_email.Location = new Point(34, 160);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(48, 21);
            lbl_email.TabIndex = 5;
            lbl_email.Text = "Email";
            // 
            // lbl_pass
            // 
            lbl_pass.AutoSize = true;
            lbl_pass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_pass.ForeColor = Color.White;
            lbl_pass.Location = new Point(30, 224);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new Size(79, 21);
            lbl_pass.TabIndex = 7;
            lbl_pass.Text = "Password";
            // 
            // lbl_Age
            // 
            lbl_Age.AutoSize = true;
            lbl_Age.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Age.ForeColor = Color.White;
            lbl_Age.Location = new Point(34, 294);
            lbl_Age.Name = "lbl_Age";
            lbl_Age.Size = new Size(78, 21);
            lbl_Age.TabIndex = 9;
            lbl_Age.Text = "Birthdate";
            // 
            // lbl_Adress
            // 
            lbl_Adress.AutoSize = true;
            lbl_Adress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Adress.ForeColor = Color.White;
            lbl_Adress.Location = new Point(34, 361);
            lbl_Adress.Name = "lbl_Adress";
            lbl_Adress.Size = new Size(60, 21);
            lbl_Adress.TabIndex = 11;
            lbl_Adress.Text = "Adress";
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_name.Location = new Point(156, 94);
            txt_name.MaximumSize = new Size(360, 50);
            txt_name.MinimumSize = new Size(360, 35);
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = "Write your Name";
            txt_name.Size = new Size(360, 35);
            txt_name.TabIndex = 0;
            // 
            // txt_adress
            // 
            txt_adress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_adress.Location = new Point(156, 347);
            txt_adress.MaximumSize = new Size(360, 50);
            txt_adress.MinimumSize = new Size(360, 35);
            txt_adress.Name = "txt_adress";
            txt_adress.PlaceholderText = "Cairo";
            txt_adress.Size = new Size(360, 35);
            txt_adress.TabIndex = 4;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.Location = new Point(156, 157);
            txt_email.MaximumSize = new Size(360, 50);
            txt_email.MinimumSize = new Size(360, 35);
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "Write Email";
            txt_email.Size = new Size(360, 35);
            txt_email.TabIndex = 1;
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_pass.Location = new Point(156, 221);
            txt_pass.MaximumSize = new Size(360, 50);
            txt_pass.MinimumSize = new Size(360, 35);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.PlaceholderText = "Write Password";
            txt_pass.Size = new Size(360, 35);
            txt_pass.TabIndex = 2;
            // 
            // btn_Submit
            // 
            btn_Submit.BackColor = Color.FromArgb(0, 64, 64);
            btn_Submit.Cursor = Cursors.Hand;
            btn_Submit.FlatAppearance.BorderSize = 0;
            btn_Submit.FlatStyle = FlatStyle.Flat;
            btn_Submit.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Submit.ForeColor = SystemColors.ButtonFace;
            btn_Submit.Image = Properties.Resources.icons8_add_48;
            btn_Submit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Submit.Location = new Point(348, 565);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(168, 55);
            btn_Submit.TabIndex = 5;
            btn_Submit.Text = "Save";
            btn_Submit.TextAlign = ContentAlignment.MiddleRight;
            btn_Submit.UseVisualStyleBackColor = false;
            btn_Submit.Click += btn_Submit_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(64, 64, 64);
            btn_back.Cursor = Cursors.Hand;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.ForeColor = SystemColors.ButtonFace;
            btn_back.Image = Properties.Resources.icons8_back_501;
            btn_back.ImageAlign = ContentAlignment.MiddleLeft;
            btn_back.Location = new Point(156, 565);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(156, 55);
            btn_back.TabIndex = 14;
            btn_back.Text = "Back";
            btn_back.TextAlign = ContentAlignment.MiddleRight;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // pic_box
            // 
            pic_box.BackgroundImageLayout = ImageLayout.Center;
            pic_box.Cursor = Cursors.Hand;
            pic_box.Image = Properties.Resources.pngwing_com12;
            pic_box.InitialImage = Properties.Resources.pngwing_com12;
            pic_box.Location = new Point(156, 399);
            pic_box.Name = "pic_box";
            pic_box.Size = new Size(360, 148);
            pic_box.SizeMode = PictureBoxSizeMode.Zoom;
            pic_box.TabIndex = 15;
            pic_box.TabStop = false;
            pic_box.Click += pic_box_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 21);
            label2.Name = "label2";
            label2.Size = new Size(277, 32);
            label2.TabIndex = 17;
            label2.Text = "Registration User Form";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_close_48;
            pictureBox2.Location = new Point(855, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 50);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 56);
            label1.Name = "label1";
            label1.Size = new Size(215, 13);
            label1.TabIndex = 20;
            label1.Text = "Fill out the form carefully for registration";
            // 
            // date_birthdate
            // 
            date_birthdate.CalendarForeColor = Color.Gray;
            date_birthdate.CalendarTitleForeColor = Color.FromArgb(64, 64, 64);
            date_birthdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date_birthdate.Location = new Point(156, 288);
            date_birthdate.Name = "date_birthdate";
            date_birthdate.Size = new Size(360, 29);
            date_birthdate.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(34, 463);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 21;
            label3.Text = "Image";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(549, 134);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(361, 298);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // frm_register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(918, 644);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(date_birthdate);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pic_box);
            Controls.Add(btn_back);
            Controls.Add(btn_Submit);
            Controls.Add(txt_pass);
            Controls.Add(txt_email);
            Controls.Add(txt_adress);
            Controls.Add(txt_name);
            Controls.Add(lbl_Adress);
            Controls.Add(lbl_Age);
            Controls.Add(lbl_pass);
            Controls.Add(lbl_email);
            Controls.Add(lbl_Name);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            Load += frm_register_Load;
            ((System.ComponentModel.ISupportInitialize)pic_box).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label lbl_Name;
        private Label lbl_email;
        private Label lbl_pass;
        private Label lbl_Age;
        private Label lbl_Adress;
        private TextBox txt_name;
        private TextBox txt_adress;
        private TextBox txt_email;
        private TextBox txt_pass;
        private Button btn_Submit;
        private Button btn_back;
        private PictureBox pic_box;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label1;
        private DateTimePicker date_birthdate;
        private Label label3;
        private PictureBox pictureBox3;
    }
}