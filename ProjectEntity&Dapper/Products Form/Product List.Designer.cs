namespace ProjectEntity_Dapper.Products_Form
{
    partial class frm_productList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_productList));
            pic_Close = new PictureBox();
            dgvProductList = new DataGridView();
            txt_search = new TextBox();
            label2 = new Label();
            btn_Create = new Button();
            label1 = new Label();
            btn_refrsh = new Button();
            label3 = new Label();
            pic_product = new PictureBox();
            txt_Productname = new TextBox();
            label4 = new Label();
            num_Quantity = new NumericUpDown();
            num_Price = new NumericUpDown();
            rtxt_discription = new RichTextBox();
            lbl_discription = new Label();
            lbl_Quantity = new Label();
            lbl_Price = new Label();
            cmb_category = new ComboBox();
            lbl_Category = new Label();
            txt_barcode = new TextBox();
            lbl_ProdName = new Label();
            btn_back = new Button();
            btn_save = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_Close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_Quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_Price).BeginInit();
            SuspendLayout();
            // 
            // pic_Close
            // 
            pic_Close.Image = (Image)resources.GetObject("pic_Close.Image");
            pic_Close.Location = new Point(1236, 12);
            pic_Close.Name = "pic_Close";
            pic_Close.Size = new Size(35, 35);
            pic_Close.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Close.TabIndex = 1;
            pic_Close.TabStop = false;
            pic_Close.Click += pic_Close_Click;
            // 
            // dgvProductList
            // 
            dgvProductList.BackgroundColor = Color.FromArgb(0, 64, 64);
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(0, 115);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.Size = new Size(737, 535);
            dgvProductList.TabIndex = 2;
            dgvProductList.RowHeaderMouseDoubleClick += dgvProductList_RowHeaderMouseDoubleClick;
            // 
            // txt_search
            // 
            txt_search.Font = new Font("Segoe UI", 12F);
            txt_search.Location = new Point(211, 74);
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = "Write Barcode or Name Product ....";
            txt_search.Size = new Size(278, 29);
            txt_search.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(143, 32);
            label2.TabIndex = 38;
            label2.Text = "Product List";
            label2.Click += label2_Click;
            // 
            // btn_Create
            // 
            btn_Create.BackColor = Color.FromArgb(0, 64, 64);
            btn_Create.Cursor = Cursors.Hand;
            btn_Create.FlatAppearance.BorderSize = 0;
            btn_Create.FlatStyle = FlatStyle.Flat;
            btn_Create.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Create.ForeColor = SystemColors.ButtonFace;
            btn_Create.Image = (Image)resources.GetObject("btn_Create.Image");
            btn_Create.ImageAlign = ContentAlignment.MiddleRight;
            btn_Create.Location = new Point(521, 66);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(164, 43);
            btn_Create.TabIndex = 11;
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
            label1.Size = new Size(178, 15);
            label1.TabIndex = 39;
            label1.Text = "Search Barcode |  Name Product";
            // 
            // btn_refrsh
            // 
            btn_refrsh.BackColor = Color.FromArgb(0, 64, 64);
            btn_refrsh.BackgroundImage = (Image)resources.GetObject("btn_refrsh.BackgroundImage");
            btn_refrsh.BackgroundImageLayout = ImageLayout.Center;
            btn_refrsh.Cursor = Cursors.Hand;
            btn_refrsh.FlatAppearance.BorderSize = 0;
            btn_refrsh.FlatStyle = FlatStyle.Flat;
            btn_refrsh.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_refrsh.ForeColor = SystemColors.ButtonFace;
            btn_refrsh.ImageAlign = ContentAlignment.MiddleRight;
            btn_refrsh.Location = new Point(691, 66);
            btn_refrsh.Name = "btn_refrsh";
            btn_refrsh.Size = new Size(46, 43);
            btn_refrsh.TabIndex = 40;
            btn_refrsh.TextAlign = ContentAlignment.MiddleLeft;
            btn_refrsh.UseVisualStyleBackColor = false;
            btn_refrsh.Click += btn_refrsh_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(868, 506);
            label3.Name = "label3";
            label3.Size = new Size(118, 21);
            label3.TabIndex = 54;
            label3.Text = "Image Product";
            // 
            // pic_product
            // 
            pic_product.Cursor = Cursors.Hand;
            pic_product.Image = (Image)resources.GetObject("pic_product.Image");
            pic_product.Location = new Point(1017, 465);
            pic_product.Name = "pic_product";
            pic_product.Size = new Size(240, 127);
            pic_product.SizeMode = PictureBoxSizeMode.Zoom;
            pic_product.TabIndex = 53;
            pic_product.TabStop = false;
            pic_product.Click += pic_product_Click;
            // 
            // txt_Productname
            // 
            txt_Productname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Productname.Location = new Point(1017, 150);
            txt_Productname.MaximumSize = new Size(240, 50);
            txt_Productname.MinimumSize = new Size(240, 35);
            txt_Productname.Name = "txt_Productname";
            txt_Productname.PlaceholderText = "Write Name Product Here......";
            txt_Productname.Size = new Size(240, 35);
            txt_Productname.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(868, 151);
            label4.Name = "label4";
            label4.Size = new Size(119, 21);
            label4.TabIndex = 52;
            label4.Text = " Name Product";
            // 
            // num_Quantity
            // 
            num_Quantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num_Quantity.ForeColor = SystemColors.WindowFrame;
            num_Quantity.ImeMode = ImeMode.NoControl;
            num_Quantity.Location = new Point(1017, 291);
            num_Quantity.Name = "num_Quantity";
            num_Quantity.Size = new Size(240, 29);
            num_Quantity.TabIndex = 5;
            // 
            // num_Price
            // 
            num_Price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num_Price.ForeColor = SystemColors.WindowFrame;
            num_Price.ImeMode = ImeMode.NoControl;
            num_Price.Location = new Point(1017, 240);
            num_Price.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            num_Price.Name = "num_Price";
            num_Price.Size = new Size(240, 29);
            num_Price.TabIndex = 4;
            // 
            // rtxt_discription
            // 
            rtxt_discription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxt_discription.Location = new Point(1017, 340);
            rtxt_discription.Name = "rtxt_discription";
            rtxt_discription.Size = new Size(240, 106);
            rtxt_discription.TabIndex = 6;
            rtxt_discription.Text = "";
            // 
            // lbl_discription
            // 
            lbl_discription.AutoSize = true;
            lbl_discription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_discription.ForeColor = Color.White;
            lbl_discription.Location = new Point(868, 368);
            lbl_discription.Name = "lbl_discription";
            lbl_discription.Size = new Size(89, 21);
            lbl_discription.TabIndex = 51;
            lbl_discription.Text = "Discription";
            // 
            // lbl_Quantity
            // 
            lbl_Quantity.AutoSize = true;
            lbl_Quantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Quantity.ForeColor = Color.White;
            lbl_Quantity.Location = new Point(868, 291);
            lbl_Quantity.Name = "lbl_Quantity";
            lbl_Quantity.Size = new Size(72, 21);
            lbl_Quantity.TabIndex = 50;
            lbl_Quantity.Text = "Quantity";
            // 
            // lbl_Price
            // 
            lbl_Price.AutoSize = true;
            lbl_Price.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Price.ForeColor = Color.White;
            lbl_Price.Location = new Point(868, 240);
            lbl_Price.Name = "lbl_Price";
            lbl_Price.Size = new Size(46, 21);
            lbl_Price.TabIndex = 49;
            lbl_Price.Text = "Price";
            // 
            // cmb_category
            // 
            cmb_category.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_category.FormattingEnabled = true;
            cmb_category.Location = new Point(1017, 195);
            cmb_category.MaximumSize = new Size(340, 0);
            cmb_category.MinimumSize = new Size(240, 0);
            cmb_category.Name = "cmb_category";
            cmb_category.Size = new Size(240, 29);
            cmb_category.TabIndex = 3;
            // 
            // lbl_Category
            // 
            lbl_Category.AutoSize = true;
            lbl_Category.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Category.ForeColor = Color.White;
            lbl_Category.Location = new Point(868, 192);
            lbl_Category.Name = "lbl_Category";
            lbl_Category.Size = new Size(71, 21);
            lbl_Category.TabIndex = 48;
            lbl_Category.Text = "Categoy";
            // 
            // txt_barcode
            // 
            txt_barcode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_barcode.Location = new Point(1017, 106);
            txt_barcode.MaximumSize = new Size(240, 50);
            txt_barcode.MinimumSize = new Size(240, 35);
            txt_barcode.Name = "txt_barcode";
            txt_barcode.PlaceholderText = "Write BarCode Here......";
            txt_barcode.Size = new Size(240, 35);
            txt_barcode.TabIndex = 1;
            // 
            // lbl_ProdName
            // 
            lbl_ProdName.AutoSize = true;
            lbl_ProdName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ProdName.ForeColor = Color.White;
            lbl_ProdName.Location = new Point(868, 106);
            lbl_ProdName.Name = "lbl_ProdName";
            lbl_ProdName.Size = new Size(73, 21);
            lbl_ProdName.TabIndex = 47;
            lbl_ProdName.Text = "BarCode";
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
            btn_back.Location = new Point(1105, 597);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(166, 50);
            btn_back.TabIndex = 8;
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
            btn_save.Location = new Point(920, 595);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(174, 52);
            btn_save.TabIndex = 7;
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
            btn_delete.Image = (Image)resources.GetObject("btn_delete.Image");
            btn_delete.ImageAlign = ContentAlignment.MiddleRight;
            btn_delete.Location = new Point(743, 596);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(165, 50);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Delete";
            btn_delete.TextAlign = ContentAlignment.MiddleLeft;
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // frm_productList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1283, 649);
            Controls.Add(btn_delete);
            Controls.Add(btn_back);
            Controls.Add(btn_save);
            Controls.Add(label3);
            Controls.Add(pic_product);
            Controls.Add(txt_Productname);
            Controls.Add(label4);
            Controls.Add(num_Quantity);
            Controls.Add(num_Price);
            Controls.Add(rtxt_discription);
            Controls.Add(lbl_discription);
            Controls.Add(lbl_Quantity);
            Controls.Add(lbl_Price);
            Controls.Add(cmb_category);
            Controls.Add(lbl_Category);
            Controls.Add(txt_barcode);
            Controls.Add(lbl_ProdName);
            Controls.Add(btn_refrsh);
            Controls.Add(label1);
            Controls.Add(btn_Create);
            Controls.Add(label2);
            Controls.Add(txt_search);
            Controls.Add(dgvProductList);
            Controls.Add(pic_Close);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_productList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product_List";
            Load += frm_productList_Load;
            ((System.ComponentModel.ISupportInitialize)pic_Close).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_product).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_Quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_Price).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_Close;
        private DataGridView dgvProductList;
        private TextBox txt_search;
        private Label label2;
        private Button btn_Create;
        private Label label1;
        private Button btn_refrsh;
        private Label label3;
        private PictureBox pic_product;
        private TextBox txt_Productname;
        private Label label4;
        private NumericUpDown num_Quantity;
        private NumericUpDown num_Price;
        private RichTextBox rtxt_discription;
        private Label lbl_discription;
        private Label lbl_Quantity;
        private Label lbl_Price;
        private ComboBox cmb_category;
        private Label lbl_Category;
        private TextBox txt_barcode;
        private Label lbl_ProdName;
        private Button btn_back;
        private Button btn_save;
        private Button btn_delete;
    }
}