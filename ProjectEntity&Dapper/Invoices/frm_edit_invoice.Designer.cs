namespace ProjectEntity_Dapper.Invoices
{
    partial class frm_edit_invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_edit_invoice));
            dtpInvoiceDate = new DateTimePicker();
            dgv_invoiceItems = new DataGridView();
            lable = new Label();
            cmbProducts = new ComboBox();
            lblTotalAmount = new Label();
            btn_back = new Button();
            btnSave = new Button();
            btn_delete = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            lblNumberInvoice = new Label();
            lblCustomer = new Label();
            label4 = new Label();
            label8 = new Label();
            numQuantity = new NumericUpDown();
            btn_addProduct = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_invoiceItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dtpInvoiceDate
            // 
            dtpInvoiceDate.Enabled = false;
            dtpInvoiceDate.Location = new Point(661, 69);
            dtpInvoiceDate.Name = "dtpInvoiceDate";
            dtpInvoiceDate.Size = new Size(240, 23);
            dtpInvoiceDate.TabIndex = 1;
            // 
            // dgv_invoiceItems
            // 
            dgv_invoiceItems.BackgroundColor = Color.FromArgb(0, 64, 64);
            dgv_invoiceItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_invoiceItems.Location = new Point(185, 219);
            dgv_invoiceItems.Name = "dgv_invoiceItems";
            dgv_invoiceItems.Size = new Size(701, 220);
            dgv_invoiceItems.TabIndex = 51;
            dgv_invoiceItems.CellContentClick += dgv_invoiceItems_CellContentClick_1;
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lable.ForeColor = Color.White;
            lable.Location = new Point(81, 110);
            lable.Name = "lable";
            lable.Size = new Size(81, 21);
            lable.TabIndex = 60;
            lable.Text = "Customer";
            // 
            // cmbProducts
            // 
            cmbProducts.Font = new Font("Segoe UI", 12F);
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(661, 122);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(240, 29);
            cmbProducts.TabIndex = 2;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.ForeColor = Color.White;
            lblTotalAmount.Location = new Point(196, 449);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(0, 32);
            lblTotalAmount.TabIndex = 61;
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
            btn_back.Location = new Point(185, 495);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(165, 54);
            btn_back.TabIndex = 5;
            btn_back.Text = "Back";
            btn_back.TextAlign = ContentAlignment.MiddleRight;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 64, 64);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.Image = Properties.Resources.icons8_update_50;
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(721, 493);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(165, 54);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(64, 64, 64);
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = SystemColors.ButtonFace;
            btn_delete.Image = (Image)resources.GetObject("btn_delete.Image");
            btn_delete.ImageAlign = ContentAlignment.MiddleRight;
            btn_delete.Location = new Point(461, 495);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(165, 54);
            btn_delete.TabIndex = 4;
            btn_delete.Text = "Delete";
            btn_delete.TextAlign = ContentAlignment.MiddleLeft;
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(178, 32);
            label2.TabIndex = 65;
            label2.Text = "Update Invoice";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(542, 69);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 66;
            label1.Text = "Data Invoice";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(81, 69);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 67;
            label3.Text = "Number Invoice";
            // 
            // lblNumberInvoice
            // 
            lblNumberInvoice.AutoSize = true;
            lblNumberInvoice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumberInvoice.ForeColor = Color.White;
            lblNumberInvoice.Location = new Point(224, 68);
            lblNumberInvoice.Name = "lblNumberInvoice";
            lblNumberInvoice.Size = new Size(0, 21);
            lblNumberInvoice.TabIndex = 68;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomer.ForeColor = Color.White;
            lblCustomer.Location = new Point(224, 110);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(0, 21);
            lblCustomer.TabIndex = 69;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(542, 125);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 70;
            label4.Text = "Product";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(82, 163);
            label8.Name = "label8";
            label8.Size = new Size(72, 21);
            label8.TabIndex = 73;
            label8.Text = "Quantity";
            // 
            // numQuantity
            // 
            numQuantity.Cursor = Cursors.Hand;
            numQuantity.Font = new Font("Segoe UI", 12F);
            numQuantity.Location = new Point(224, 161);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(240, 29);
            numQuantity.TabIndex = 1;
            // 
            // btn_addProduct
            // 
            btn_addProduct.BackColor = Color.Transparent;
            btn_addProduct.BackgroundImage = Properties.Resources.icons8_add_48;
            btn_addProduct.BackgroundImageLayout = ImageLayout.Stretch;
            btn_addProduct.Cursor = Cursors.Hand;
            btn_addProduct.FlatAppearance.BorderSize = 0;
            btn_addProduct.FlatStyle = FlatStyle.Flat;
            btn_addProduct.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_addProduct.ForeColor = SystemColors.ButtonFace;
            btn_addProduct.Location = new Point(471, 159);
            btn_addProduct.Name = "btn_addProduct";
            btn_addProduct.Size = new Size(43, 35);
            btn_addProduct.TabIndex = 72;
            btn_addProduct.TextAlign = ContentAlignment.MiddleLeft;
            btn_addProduct.UseVisualStyleBackColor = false;
            btn_addProduct.Click += btn_addProduct_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_close_48;
            pictureBox2.Location = new Point(917, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 74;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // frm_edit_invoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(966, 561);
            Controls.Add(pictureBox2);
            Controls.Add(label8);
            Controls.Add(numQuantity);
            Controls.Add(btn_addProduct);
            Controls.Add(label4);
            Controls.Add(lblCustomer);
            Controls.Add(lblNumberInvoice);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btn_delete);
            Controls.Add(btn_back);
            Controls.Add(btnSave);
            Controls.Add(lblTotalAmount);
            Controls.Add(lable);
            Controls.Add(cmbProducts);
            Controls.Add(dgv_invoiceItems);
            Controls.Add(dtpInvoiceDate);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_edit_invoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_edit_invoice";
            Load += frm_edit_invoice_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_invoiceItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpInvoiceDate;
        private DataGridView dgv_invoiceItems;
        private Label lable;
        private ComboBox cmbProducts;
        private Label lblTotalAmount;
        private Button btn_back;
        private Button btnSave;
        private Button btn_delete;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label lblNumberInvoice;
        private Label lblCustomer;
        private Label label4;
        private Label label8;
        private NumericUpDown numQuantity;
        private Button btn_addProduct;
        private PictureBox pictureBox2;
    }
}