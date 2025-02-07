namespace ProjectEntity_Dapper
{
    partial class frm_AdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AdminMain));
            pic_profile = new PictureBox();
            menuStrip1 = new MenuStrip();
            userToolStripMenuItem = new ToolStripMenuItem();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            liToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            addNewProductToolStripMenuItem = new ToolStripMenuItem();
            listProductToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            customersToolStripMenuItem = new ToolStripMenuItem();
            addNewInToolStripMenuItem = new ToolStripMenuItem();
            listInvoicesToolStripMenuItem = new ToolStripMenuItem();
            btn_users = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label2 = new Label();
            btn_products = new Button();
            groupBox3 = new GroupBox();
            label3 = new Label();
            btn_customers = new Button();
            groupBox4 = new GroupBox();
            label4 = new Label();
            btn_suplier = new Button();
            pic_min = new PictureBox();
            pic_max = new PictureBox();
            pic_Close = new PictureBox();
            lbl_uername = new Label();
            button1 = new Button();
            manageCategoryToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pic_profile).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_min).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_max).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Close).BeginInit();
            SuspendLayout();
            // 
            // pic_profile
            // 
            pic_profile.Cursor = Cursors.Hand;
            pic_profile.Image = (Image)resources.GetObject("pic_profile.Image");
            pic_profile.Location = new Point(12, 10);
            pic_profile.Name = "pic_profile";
            pic_profile.Size = new Size(52, 43);
            pic_profile.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_profile.TabIndex = 3;
            pic_profile.TabStop = false;
            pic_profile.Click += pic_profile_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.GripMargin = new Padding(8, 2, 0, 2);
            menuStrip1.Items.AddRange(new ToolStripItem[] { userToolStripMenuItem, addToolStripMenuItem, toolStripMenuItem1, customersToolStripMenuItem });
            menuStrip1.Location = new Point(289, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(524, 29);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addUserToolStripMenuItem, liToolStripMenuItem });
            userToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userToolStripMenuItem.ForeColor = Color.White;
            userToolStripMenuItem.Image = Properties.Resources.pngwing_com12;
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(79, 25);
            userToolStripMenuItem.Text = "Users";
            userToolStripMenuItem.Click += userToolStripMenuItem_Click;
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Image = Properties.Resources.icons8_add_48;
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(149, 26);
            addUserToolStripMenuItem.Text = "Add User";
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            // 
            // liToolStripMenuItem
            // 
            liToolStripMenuItem.Image = Properties.Resources.icons8_view_48;
            liToolStripMenuItem.Name = "liToolStripMenuItem";
            liToolStripMenuItem.Size = new Size(149, 26);
            liToolStripMenuItem.Text = "List User";
            liToolStripMenuItem.Click += liToolStripMenuItem_Click;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewProductToolStripMenuItem, listProductToolStripMenuItem, manageCategoryToolStripMenuItem });
            addToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addToolStripMenuItem.ForeColor = Color.White;
            addToolStripMenuItem.Image = Properties.Resources.png_transparent_warehouse_inventory_inventory_management_software_inventory_control_warehouse_management_system_taking_logo_logistics_thumbnail;
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(105, 25);
            addToolStripMenuItem.Text = "Products";
            // 
            // addNewProductToolStripMenuItem
            // 
            addNewProductToolStripMenuItem.Image = Properties.Resources.icons8_add_48;
            addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            addNewProductToolStripMenuItem.Size = new Size(216, 26);
            addNewProductToolStripMenuItem.Text = "Add New Product";
            addNewProductToolStripMenuItem.Click += addNewProductToolStripMenuItem_Click;
            // 
            // listProductToolStripMenuItem
            // 
            listProductToolStripMenuItem.Image = Properties.Resources.icons8_view_48;
            listProductToolStripMenuItem.Name = "listProductToolStripMenuItem";
            listProductToolStripMenuItem.Size = new Size(216, 26);
            listProductToolStripMenuItem.Text = "List Product";
            listProductToolStripMenuItem.Click += listProductToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem4 });
            toolStripMenuItem1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripMenuItem1.ForeColor = Color.White;
            toolStripMenuItem1.Image = Properties.Resources.png_transparent_warehouse_inventory_inventory_management_software_inventory_control_warehouse_management_system_taking_logo_logistics_thumbnail;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(111, 25);
            toolStripMenuItem1.Text = "Customer";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Image = Properties.Resources.icons8_add_48;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(227, 26);
            toolStripMenuItem2.Text = "Add New Customer";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Image = Properties.Resources.icons8_view_48;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(227, 26);
            toolStripMenuItem4.Text = "List Customer";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewInToolStripMenuItem, listInvoicesToolStripMenuItem });
            customersToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customersToolStripMenuItem.ForeColor = Color.White;
            customersToolStripMenuItem.Image = Properties.Resources.png_transparent_facebook_computer_icons_warehouse_management_system_business_youtube_group_text_silhouette_advertising_thumbnail;
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(101, 25);
            customersToolStripMenuItem.Text = "Invoices";
            // 
            // addNewInToolStripMenuItem
            // 
            addNewInToolStripMenuItem.Image = Properties.Resources.icons8_add_48;
            addNewInToolStripMenuItem.Name = "addNewInToolStripMenuItem";
            addNewInToolStripMenuItem.Size = new Size(210, 26);
            addNewInToolStripMenuItem.Text = "Add New Invoice";
            addNewInToolStripMenuItem.Click += addNewInToolStripMenuItem_Click;
            // 
            // listInvoicesToolStripMenuItem
            // 
            listInvoicesToolStripMenuItem.Image = Properties.Resources.icons8_view_48;
            listInvoicesToolStripMenuItem.Name = "listInvoicesToolStripMenuItem";
            listInvoicesToolStripMenuItem.Size = new Size(210, 26);
            listInvoicesToolStripMenuItem.Text = "List Invoices";
            listInvoicesToolStripMenuItem.Click += listInvoicesToolStripMenuItem_Click;
            // 
            // btn_users
            // 
            btn_users.BackgroundImage = (Image)resources.GetObject("btn_users.BackgroundImage");
            btn_users.BackgroundImageLayout = ImageLayout.Stretch;
            btn_users.Cursor = Cursors.Hand;
            btn_users.FlatAppearance.BorderSize = 0;
            btn_users.FlatStyle = FlatStyle.Flat;
            btn_users.Location = new Point(57, 46);
            btn_users.Name = "btn_users";
            btn_users.Size = new Size(123, 131);
            btn_users.TabIndex = 5;
            btn_users.UseVisualStyleBackColor = true;
            btn_users.Click += btn_users_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_users);
            groupBox1.Location = new Point(733, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 247);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(88, 180);
            label1.Name = "label1";
            label1.Size = new Size(65, 30);
            label1.TabIndex = 6;
            label1.Text = "Users";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btn_products);
            groupBox2.Location = new Point(493, 140);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(215, 247);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
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
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(btn_customers);
            groupBox3.Location = new Point(257, 140);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(215, 247);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
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
            // groupBox4
            // 
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(btn_suplier);
            groupBox4.Location = new Point(12, 140);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(215, 247);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
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
            // pic_min
            // 
            pic_min.Enabled = false;
            pic_min.Image = (Image)resources.GetObject("pic_min.Image");
            pic_min.Location = new Point(828, 12);
            pic_min.Name = "pic_min";
            pic_min.Size = new Size(35, 35);
            pic_min.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_min.TabIndex = 12;
            pic_min.TabStop = false;
            // 
            // pic_max
            // 
            pic_max.Enabled = false;
            pic_max.Image = (Image)resources.GetObject("pic_max.Image");
            pic_max.Location = new Point(869, 12);
            pic_max.Name = "pic_max";
            pic_max.Size = new Size(35, 35);
            pic_max.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_max.TabIndex = 11;
            pic_max.TabStop = false;
            // 
            // pic_Close
            // 
            pic_Close.Image = (Image)resources.GetObject("pic_Close.Image");
            pic_Close.Location = new Point(910, 12);
            pic_Close.Name = "pic_Close";
            pic_Close.Size = new Size(35, 35);
            pic_Close.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Close.TabIndex = 10;
            pic_Close.TabStop = false;
            pic_Close.Click += pic_Close_Click;
            // 
            // lbl_uername
            // 
            lbl_uername.AutoSize = true;
            lbl_uername.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_uername.ForeColor = Color.White;
            lbl_uername.Location = new Point(70, 27);
            lbl_uername.Name = "lbl_uername";
            lbl_uername.Size = new Size(0, 19);
            lbl_uername.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 463);
            button1.Name = "button1";
            button1.Size = new Size(70, 52);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // manageCategoryToolStripMenuItem
            // 
            manageCategoryToolStripMenuItem.Image = (Image)resources.GetObject("manageCategoryToolStripMenuItem.Image");
            manageCategoryToolStripMenuItem.Name = "manageCategoryToolStripMenuItem";
            manageCategoryToolStripMenuItem.Size = new Size(216, 26);
            manageCategoryToolStripMenuItem.Text = "Manage Category";
            manageCategoryToolStripMenuItem.Click += manageCategoryToolStripMenuItem_Click;
            // 
            // frm_AdminMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(961, 527);
            Controls.Add(button1);
            Controls.Add(lbl_uername);
            Controls.Add(pic_min);
            Controls.Add(pic_max);
            Controls.Add(pic_Close);
            Controls.Add(groupBox4);
            Controls.Add(pic_profile);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "frm_AdminMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += frm_main_Load;
            ((System.ComponentModel.ISupportInitialize)pic_profile).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_min).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_max).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Close).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pic_profile;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem addNewProductToolStripMenuItem;
        private ToolStripMenuItem listProductToolStripMenuItem;
        private ToolStripMenuItem customersToolStripMenuItem;
        private Button btn_users;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private Button btn_products;
        private GroupBox groupBox3;
        private Label label3;
        private Button btn_customers;
        private GroupBox groupBox4;
        private Label label4;
        private Button btn_suplier;
        private ToolStripMenuItem liToolStripMenuItem;
        private PictureBox pic_min;
        private PictureBox pic_max;
        private PictureBox pic_Close;
        private Label lbl_uername;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem addNewInToolStripMenuItem;
        private ToolStripMenuItem listInvoicesToolStripMenuItem;
        private Button button1;
        private ToolStripMenuItem manageCategoryToolStripMenuItem;
    }
}