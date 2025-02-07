using ProjectEntity_Dapper.Products_Form;

namespace ProjectEntity_Dapper.Customer
{
    partial class frm_listCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_listCustomer));
            pic_Close = new PictureBox();
            dgvCustomerList = new DataGridView();
            txt_search = new TextBox();
            label2 = new Label();
            btn_Create = new Button();
            label1 = new Label();
            btn_refrsh = new Button();
            btn_back = new Button();
            btn_save = new Button();
            btn_delete = new Button();
            txt_Country = new TextBox();
            label5 = new Label();
            txt_City = new TextBox();
            label4 = new Label();
            txt_Address = new TextBox();
            label3 = new Label();
            txt_Email = new TextBox();
            label6 = new Label();
            txt_phone = new TextBox();
            lbl_phone = new Label();
            rtxt_discription = new RichTextBox();
            lbl_discription = new Label();
            txt_name = new TextBox();
            lbl_Name = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_Close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).BeginInit();
            SuspendLayout();
            // 
            // pic_Close
            // 
            pic_Close.Image = Properties.Resources.icons8_close_48;
            pic_Close.Location = new Point(1207, 12);
            pic_Close.Name = "pic_Close";
            pic_Close.Size = new Size(35, 35);
            pic_Close.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Close.TabIndex = 1;
            pic_Close.TabStop = false;
            pic_Close.Click += pic_Close_Click;
            // 
            // dgvCustomerList
            // 
            dgvCustomerList.BackgroundColor = Color.FromArgb(0, 64, 64);
            dgvCustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerList.Location = new Point(0, 115);
            dgvCustomerList.Name = "dgvCustomerList";
            dgvCustomerList.Size = new Size(737, 535);
            dgvCustomerList.TabIndex = 2;
            dgvCustomerList.RowHeaderMouseDoubleClick += dgvCustomerList_RowHeaderMouseDoubleClick;
            // 
            // txt_search
            // 
            txt_search.Font = new Font("Segoe UI", 12F);
            txt_search.Location = new Point(211, 74);
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = "Write Phone or Name Customer....";
            txt_search.Size = new Size(278, 29);
            txt_search.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(163, 32);
            label2.TabIndex = 38;
            label2.Text = "Customer List";
            // 
            // btn_Create
            // 
            btn_Create.BackColor = Color.FromArgb(0, 64, 64);
            btn_Create.Cursor = Cursors.Hand;
            btn_Create.FlatAppearance.BorderSize = 0;
            btn_Create.FlatStyle = FlatStyle.Flat;
            btn_Create.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Create.ForeColor = SystemColors.ButtonFace;
            btn_Create.Image = Properties.Resources.icons8_search_48;
            btn_Create.ImageAlign = ContentAlignment.MiddleRight;
            btn_Create.Location = new Point(521, 66);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(164, 43);
            btn_Create.TabIndex = 2;
            btn_Create.Text = "Search";
            btn_Create.TextAlign = ContentAlignment.MiddleLeft;
            btn_Create.UseVisualStyleBackColor = false;
            btn_Create.Click += btn_Create_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 82);
            label1.Name = "label1";
            label1.Size = new Size(181, 15);
            label1.TabIndex = 39;
            label1.Text = "Search Phone |  Name Customer ";
            // 
            // btn_refrsh
            // 
            btn_refrsh.BackColor = Color.FromArgb(0, 64, 64);
            btn_refrsh.BackgroundImageLayout = ImageLayout.Center;
            btn_refrsh.Cursor = Cursors.Hand;
            btn_refrsh.FlatAppearance.BorderSize = 0;
            btn_refrsh.FlatStyle = FlatStyle.Flat;
            btn_refrsh.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_refrsh.ForeColor = SystemColors.ButtonFace;
            btn_refrsh.Image = Properties.Resources.icons8_refresh_40;
            btn_refrsh.ImageAlign = ContentAlignment.MiddleRight;
            btn_refrsh.Location = new Point(691, 66);
            btn_refrsh.Name = "btn_refrsh";
            btn_refrsh.Size = new Size(46, 43);
            btn_refrsh.TabIndex = 40;
            btn_refrsh.TextAlign = ContentAlignment.MiddleLeft;
            btn_refrsh.UseVisualStyleBackColor = false;
            btn_refrsh.Click += btn_refrsh_Click;
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
            btn_back.Location = new Point(1112, 595);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(130, 50);
            btn_back.TabIndex = 12;
            btn_back.Text = "Back";
            btn_back.TextAlign = ContentAlignment.MiddleRight;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(0, 64, 64);
            btn_save.Cursor = Cursors.Hand;
            btn_save.Enabled = false;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.ForeColor = SystemColors.ButtonFace;
            btn_save.Image = Properties.Resources.icons8_update_50;
            btn_save.ImageAlign = ContentAlignment.MiddleRight;
            btn_save.Location = new Point(927, 593);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(149, 52);
            btn_save.TabIndex = 11;
            btn_save.Text = "Save";
            btn_save.TextAlign = ContentAlignment.MiddleLeft;
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(64, 64, 64);
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.Enabled = false;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = SystemColors.ButtonFace;
            btn_delete.Image = Properties.Resources.icons8_delete_50;
            btn_delete.ImageAlign = ContentAlignment.MiddleRight;
            btn_delete.Location = new Point(752, 593);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(141, 50);
            btn_delete.TabIndex = 13;
            btn_delete.Text = "Delete";
            btn_delete.TextAlign = ContentAlignment.MiddleLeft;
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // txt_Country
            // 
            txt_Country.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Country.Location = new Point(951, 375);
            txt_Country.MaximumSize = new Size(240, 50);
            txt_Country.MinimumSize = new Size(240, 35);
            txt_Country.Name = "txt_Country";
            txt_Country.PlaceholderText = "Country";
            txt_Country.Size = new Size(240, 35);
            txt_Country.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(804, 389);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 71;
            label5.Text = "Country";
            // 
            // txt_City
            // 
            txt_City.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_City.Location = new Point(951, 321);
            txt_City.MaximumSize = new Size(240, 50);
            txt_City.MinimumSize = new Size(240, 35);
            txt_City.Name = "txt_City";
            txt_City.PlaceholderText = "City";
            txt_City.Size = new Size(240, 35);
            txt_City.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(804, 321);
            label4.Name = "label4";
            label4.Size = new Size(38, 21);
            label4.TabIndex = 70;
            label4.Text = "City";
            // 
            // txt_Address
            // 
            txt_Address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Address.Location = new Point(951, 256);
            txt_Address.MaximumSize = new Size(240, 50);
            txt_Address.MinimumSize = new Size(240, 35);
            txt_Address.Name = "txt_Address";
            txt_Address.PlaceholderText = "Address";
            txt_Address.Size = new Size(240, 35);
            txt_Address.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(804, 256);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 69;
            label3.Text = "Address";
            // 
            // txt_Email
            // 
            txt_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Email.Location = new Point(951, 194);
            txt_Email.MaximumSize = new Size(240, 50);
            txt_Email.MinimumSize = new Size(240, 35);
            txt_Email.Name = "txt_Email";
            txt_Email.PlaceholderText = "Write Email";
            txt_Email.Size = new Size(240, 35);
            txt_Email.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(804, 194);
            label6.Name = "label6";
            label6.Size = new Size(48, 21);
            label6.TabIndex = 68;
            label6.Text = "Email";
            // 
            // txt_phone
            // 
            txt_phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_phone.Location = new Point(951, 127);
            txt_phone.MaximumSize = new Size(240, 50);
            txt_phone.MinimumSize = new Size(240, 35);
            txt_phone.Name = "txt_phone";
            txt_phone.PlaceholderText = "Phone Number";
            txt_phone.Size = new Size(240, 35);
            txt_phone.TabIndex = 4;
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_phone.ForeColor = Color.White;
            lbl_phone.Location = new Point(804, 127);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(56, 21);
            lbl_phone.TabIndex = 67;
            lbl_phone.Text = "Phone";
            // 
            // rtxt_discription
            // 
            rtxt_discription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxt_discription.Location = new Point(951, 429);
            rtxt_discription.Name = "rtxt_discription";
            rtxt_discription.Size = new Size(240, 113);
            rtxt_discription.TabIndex = 10;
            rtxt_discription.Text = "";
            // 
            // lbl_discription
            // 
            lbl_discription.AutoSize = true;
            lbl_discription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_discription.ForeColor = Color.White;
            lbl_discription.Location = new Point(804, 475);
            lbl_discription.Name = "lbl_discription";
            lbl_discription.Size = new Size(89, 21);
            lbl_discription.TabIndex = 66;
            lbl_discription.Text = "Discription";
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_name.Location = new Point(951, 68);
            txt_name.MaximumSize = new Size(240, 50);
            txt_name.MinimumSize = new Size(240, 35);
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = "Write Name Here......";
            txt_name.Size = new Size(240, 35);
            txt_name.TabIndex = 3;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Name.ForeColor = Color.White;
            lbl_Name.Location = new Point(804, 71);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(53, 21);
            lbl_Name.TabIndex = 65;
            lbl_Name.Text = "Name";
            // 
            // frm_listCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1253, 649);
            Controls.Add(txt_Country);
            Controls.Add(label5);
            Controls.Add(txt_City);
            Controls.Add(label4);
            Controls.Add(txt_Address);
            Controls.Add(label3);
            Controls.Add(txt_Email);
            Controls.Add(label6);
            Controls.Add(txt_phone);
            Controls.Add(lbl_phone);
            Controls.Add(rtxt_discription);
            Controls.Add(lbl_discription);
            Controls.Add(txt_name);
            Controls.Add(lbl_Name);
            Controls.Add(btn_delete);
            Controls.Add(btn_back);
            Controls.Add(btn_save);
            Controls.Add(btn_refrsh);
            Controls.Add(label1);
            Controls.Add(btn_Create);
            Controls.Add(label2);
            Controls.Add(txt_search);
            Controls.Add(dgvCustomerList);
            Controls.Add(pic_Close);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_listCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product_List";
            Load += frm_listCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)pic_Close).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_Close;
        private DataGridView dgvCustomerList;
        private TextBox txt_search;
        private Label label2;
        private Button btn_Create;
        private Label label1;
        private Button btn_refrsh;
        private Button btn_back;
        private Button btn_save;
        private Button btn_delete;
        private TextBox txt_Country;
        private Label label5;
        private TextBox txt_City;
        private Label label4;
        private TextBox txt_Address;
        private Label label3;
        private TextBox txt_Email;
        private Label label6;
        private TextBox txt_phone;
        private Label lbl_phone;
        private RichTextBox rtxt_discription;
        private Label lbl_discription;
        private TextBox txt_name;
        private Label lbl_Name;
    }
}