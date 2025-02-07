namespace ProjectEntity_Dapper.Customer
{
    partial class frm_addCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_addCustomer));
            txt_name = new TextBox();
            lbl_Name = new Label();
            lbl_discription = new Label();
            rtxt_discription = new RichTextBox();
            btn_Create = new Button();
            btn_back = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            txt_phone = new TextBox();
            lbl_phone = new Label();
            txt_Email = new TextBox();
            label1 = new Label();
            txt_Address = new TextBox();
            label3 = new Label();
            txt_City = new TextBox();
            label4 = new Label();
            txt_Country = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_name.Location = new Point(159, 69);
            txt_name.MaximumSize = new Size(240, 50);
            txt_name.MinimumSize = new Size(240, 35);
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = "Write Name Here......";
            txt_name.Size = new Size(240, 35);
            txt_name.TabIndex = 1;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Name.ForeColor = Color.White;
            lbl_Name.Location = new Point(12, 72);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(53, 21);
            lbl_Name.TabIndex = 7;
            lbl_Name.Text = "Name";
            // 
            // lbl_discription
            // 
            lbl_discription.AutoSize = true;
            lbl_discription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_discription.ForeColor = Color.White;
            lbl_discription.Location = new Point(12, 476);
            lbl_discription.Name = "lbl_discription";
            lbl_discription.Size = new Size(89, 21);
            lbl_discription.TabIndex = 15;
            lbl_discription.Text = "Discription";
            // 
            // rtxt_discription
            // 
            rtxt_discription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxt_discription.Location = new Point(159, 430);
            rtxt_discription.Name = "rtxt_discription";
            rtxt_discription.Size = new Size(240, 113);
            rtxt_discription.TabIndex = 7;
            rtxt_discription.Text = "";
            // 
            // btn_Create
            // 
            btn_Create.BackColor = Color.FromArgb(0, 64, 64);
            btn_Create.Cursor = Cursors.Hand;
            btn_Create.FlatAppearance.BorderSize = 0;
            btn_Create.FlatStyle = FlatStyle.Flat;
            btn_Create.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Create.ForeColor = SystemColors.ButtonFace;
            btn_Create.Image = Properties.Resources.icons8_add_48;
            btn_Create.ImageAlign = ContentAlignment.MiddleRight;
            btn_Create.Location = new Point(234, 581);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(165, 54);
            btn_Create.TabIndex = 8;
            btn_Create.Text = "Add";
            btn_Create.TextAlign = ContentAlignment.MiddleLeft;
            btn_Create.UseVisualStyleBackColor = false;
            btn_Create.Click += btn_Create_Click;
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
            btn_back.Location = new Point(17, 581);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(165, 54);
            btn_back.TabIndex = 9;
            btn_back.Text = "Back";
            btn_back.TextAlign = ContentAlignment.MiddleRight;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_close_48;
            pictureBox2.Location = new Point(783, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 6);
            label2.Name = "label2";
            label2.Size = new Size(170, 32);
            label2.TabIndex = 37;
            label2.Text = "Add Customer";
            // 
            // txt_phone
            // 
            txt_phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_phone.Location = new Point(159, 128);
            txt_phone.MaximumSize = new Size(240, 50);
            txt_phone.MinimumSize = new Size(240, 35);
            txt_phone.Name = "txt_phone";
            txt_phone.PlaceholderText = "Phone Number";
            txt_phone.Size = new Size(240, 35);
            txt_phone.TabIndex = 2;
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_phone.ForeColor = Color.White;
            lbl_phone.Location = new Point(12, 128);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(56, 21);
            lbl_phone.TabIndex = 39;
            lbl_phone.Text = "Phone";
            // 
            // txt_Email
            // 
            txt_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Email.Location = new Point(159, 195);
            txt_Email.MaximumSize = new Size(240, 50);
            txt_Email.MinimumSize = new Size(240, 35);
            txt_Email.Name = "txt_Email";
            txt_Email.PlaceholderText = "Write Email";
            txt_Email.Size = new Size(240, 35);
            txt_Email.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 195);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 41;
            label1.Text = "Email";
            // 
            // txt_Address
            // 
            txt_Address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Address.Location = new Point(159, 257);
            txt_Address.MaximumSize = new Size(240, 50);
            txt_Address.MinimumSize = new Size(240, 35);
            txt_Address.Name = "txt_Address";
            txt_Address.PlaceholderText = "Address";
            txt_Address.Size = new Size(240, 35);
            txt_Address.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 257);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 43;
            label3.Text = "Address";
            // 
            // txt_City
            // 
            txt_City.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_City.Location = new Point(159, 322);
            txt_City.MaximumSize = new Size(240, 50);
            txt_City.MinimumSize = new Size(240, 35);
            txt_City.Name = "txt_City";
            txt_City.PlaceholderText = "City";
            txt_City.Size = new Size(240, 35);
            txt_City.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 322);
            label4.Name = "label4";
            label4.Size = new Size(38, 21);
            label4.TabIndex = 45;
            label4.Text = "City";
            // 
            // txt_Country
            // 
            txt_Country.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Country.Location = new Point(159, 376);
            txt_Country.MaximumSize = new Size(240, 50);
            txt_Country.MinimumSize = new Size(240, 35);
            txt_Country.Name = "txt_Country";
            txt_Country.PlaceholderText = "Country";
            txt_Country.Size = new Size(240, 35);
            txt_Country.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 390);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 47;
            label5.Text = "Country";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(452, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 354);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // frm_addCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(832, 647);
            Controls.Add(pictureBox1);
            Controls.Add(txt_Country);
            Controls.Add(label5);
            Controls.Add(txt_City);
            Controls.Add(label4);
            Controls.Add(txt_Address);
            Controls.Add(label3);
            Controls.Add(txt_Email);
            Controls.Add(label1);
            Controls.Add(txt_phone);
            Controls.Add(lbl_phone);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(btn_back);
            Controls.Add(btn_Create);
            Controls.Add(rtxt_discription);
            Controls.Add(lbl_discription);
            Controls.Add(txt_name);
            Controls.Add(lbl_Name);
            ForeColor = SystemColors.ControlDarkDark;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_addCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name;
        private Label lbl_Name;
        private Label lbl_discription;
        private RichTextBox rtxt_discription;
        private Button btn_Create;
        private Button btn_back;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox txt_phone;
        private Label lbl_phone;
        private TextBox txt_Email;
        private Label label1;
        private TextBox txt_Address;
        private Label label3;
        private TextBox txt_City;
        private Label label4;
        private TextBox txt_Country;
        private Label label5;
        private PictureBox pictureBox1;
    }
}