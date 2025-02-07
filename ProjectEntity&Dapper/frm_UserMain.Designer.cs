namespace ProjectEntity_Dapper
{
    partial class frm_UserMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UserMain));
            lbl_uername = new Label();
            pic_min = new PictureBox();
            pic_max = new PictureBox();
            label4 = new Label();
            btn_suplier = new Button();
            groupBox4 = new GroupBox();
            label3 = new Label();
            btn_customers = new Button();
            groupBox3 = new GroupBox();
            label2 = new Label();
            btn_products = new Button();
            groupBox2 = new GroupBox();
            pic_Close = new PictureBox();
            pic_profile = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_min).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_max).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_profile).BeginInit();
            SuspendLayout();
            // 
            // lbl_uername
            // 
            lbl_uername.AutoSize = true;
            lbl_uername.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_uername.ForeColor = Color.White;
            lbl_uername.Location = new Point(76, 36);
            lbl_uername.Name = "lbl_uername";
            lbl_uername.Size = new Size(0, 19);
            lbl_uername.TabIndex = 15;
            // 
            // pic_min
            // 
            pic_min.Enabled = false;
            pic_min.Image = (Image)resources.GetObject("pic_min.Image");
            pic_min.Location = new Point(834, 21);
            pic_min.Name = "pic_min";
            pic_min.Size = new Size(35, 35);
            pic_min.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_min.TabIndex = 22;
            pic_min.TabStop = false;
            // 
            // pic_max
            // 
            pic_max.Enabled = false;
            pic_max.Image = (Image)resources.GetObject("pic_max.Image");
            pic_max.Location = new Point(875, 21);
            pic_max.Name = "pic_max";
            pic_max.Size = new Size(35, 35);
            pic_max.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_max.TabIndex = 21;
            pic_max.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(53, 180);
            label4.Name = "label4";
            label4.Size = new Size(93, 30);
            label4.TabIndex = 6;
            label4.Text = "Invoices";
            // 
            // btn_suplier
            // 
            btn_suplier.BackgroundImage = (Image)resources.GetObject("btn_suplier.BackgroundImage");
            btn_suplier.BackgroundImageLayout = ImageLayout.Stretch;
            btn_suplier.Cursor = Cursors.Hand;
            btn_suplier.FlatAppearance.BorderSize = 0;
            btn_suplier.FlatStyle = FlatStyle.Flat;
            btn_suplier.Location = new Point(44, 44);
            btn_suplier.Name = "btn_suplier";
            btn_suplier.Size = new Size(123, 131);
            btn_suplier.TabIndex = 5;
            btn_suplier.UseVisualStyleBackColor = true;
            btn_suplier.Click += btn_suplier_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(btn_suplier);
            groupBox4.Location = new Point(67, 149);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(215, 247);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(53, 180);
            label3.Name = "label3";
            label3.Size = new Size(116, 30);
            label3.TabIndex = 6;
            label3.Text = "Customers";
            // 
            // btn_customers
            // 
            btn_customers.BackgroundImage = (Image)resources.GetObject("btn_customers.BackgroundImage");
            btn_customers.BackgroundImageLayout = ImageLayout.Stretch;
            btn_customers.Cursor = Cursors.Hand;
            btn_customers.FlatAppearance.BorderSize = 0;
            btn_customers.FlatStyle = FlatStyle.Flat;
            btn_customers.Location = new Point(44, 46);
            btn_customers.Name = "btn_customers";
            btn_customers.Size = new Size(123, 131);
            btn_customers.TabIndex = 5;
            btn_customers.UseVisualStyleBackColor = true;
            btn_customers.Click += btn_customers_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(btn_customers);
            groupBox3.Location = new Point(370, 149);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(215, 247);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(53, 180);
            label2.Name = "label2";
            label2.Size = new Size(100, 30);
            label2.TabIndex = 6;
            label2.Text = "Products";
            // 
            // btn_products
            // 
            btn_products.BackgroundImage = (Image)resources.GetObject("btn_products.BackgroundImage");
            btn_products.BackgroundImageLayout = ImageLayout.Stretch;
            btn_products.Cursor = Cursors.Hand;
            btn_products.FlatAppearance.BorderSize = 0;
            btn_products.FlatStyle = FlatStyle.Flat;
            btn_products.Location = new Point(44, 46);
            btn_products.Name = "btn_products";
            btn_products.Size = new Size(123, 131);
            btn_products.TabIndex = 5;
            btn_products.UseVisualStyleBackColor = true;
            btn_products.Click += btn_products_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btn_products);
            groupBox2.Location = new Point(686, 149);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(215, 247);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            // 
            // pic_Close
            // 
            pic_Close.Image = (Image)resources.GetObject("pic_Close.Image");
            pic_Close.Location = new Point(916, 21);
            pic_Close.Name = "pic_Close";
            pic_Close.Size = new Size(35, 35);
            pic_Close.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Close.TabIndex = 20;
            pic_Close.TabStop = false;
            pic_Close.Click += pic_Close_Click;
            // 
            // pic_profile
            // 
            pic_profile.Cursor = Cursors.Hand;
            pic_profile.Image = (Image)resources.GetObject("pic_profile.Image");
            pic_profile.Location = new Point(18, 19);
            pic_profile.Name = "pic_profile";
            pic_profile.Size = new Size(52, 43);
            pic_profile.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_profile.TabIndex = 13;
            pic_profile.TabStop = false;
            pic_profile.Click += pic_profile_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 438);
            button1.Name = "button1";
            button1.Size = new Size(70, 52);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frm_UserMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(978, 502);
            Controls.Add(button1);
            Controls.Add(lbl_uername);
            Controls.Add(pic_min);
            Controls.Add(pic_max);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(pic_Close);
            Controls.Add(pic_profile);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_UserMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_UserMain";
            Load += frm_UserMain_Load;
            ((System.ComponentModel.ISupportInitialize)pic_min).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_max).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_profile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_uername;
        private PictureBox pic_min;
        private PictureBox pic_max;
        private Label label4;
        private Button btn_suplier;
        private GroupBox groupBox4;
        private Label label3;
        private Button btn_customers;
        private GroupBox groupBox3;
        private Label label2;
        private Button btn_products;
        private GroupBox groupBox2;
        private PictureBox pic_Close;
        private PictureBox pic_profile;
        private Button button1;
    }
}