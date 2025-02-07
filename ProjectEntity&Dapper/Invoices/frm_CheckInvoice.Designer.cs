namespace ProjectEntity_Dapper.Invoices
{
    partial class frm_CheckInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CheckInvoice));
            btn_CheckInvoice = new Button();
            txt_InvoiceNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pic_Close = new PictureBox();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_Close).BeginInit();
            SuspendLayout();
            // 
            // btn_CheckInvoice
            // 
            btn_CheckInvoice.BackColor = Color.FromArgb(0, 64, 64);
            btn_CheckInvoice.Cursor = Cursors.Hand;
            btn_CheckInvoice.FlatAppearance.BorderSize = 0;
            btn_CheckInvoice.FlatStyle = FlatStyle.Flat;
            btn_CheckInvoice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CheckInvoice.ForeColor = SystemColors.ButtonFace;
            btn_CheckInvoice.Image = (Image)resources.GetObject("btn_CheckInvoice.Image");
            btn_CheckInvoice.ImageAlign = ContentAlignment.MiddleRight;
            btn_CheckInvoice.Location = new Point(455, 194);
            btn_CheckInvoice.Name = "btn_CheckInvoice";
            btn_CheckInvoice.Size = new Size(164, 43);
            btn_CheckInvoice.TabIndex = 2;
            btn_CheckInvoice.Text = "Search";
            btn_CheckInvoice.TextAlign = ContentAlignment.MiddleLeft;
            btn_CheckInvoice.UseVisualStyleBackColor = false;
            btn_CheckInvoice.Click += btn_CheckInvoice_Click;
            // 
            // txt_InvoiceNumber
            // 
            txt_InvoiceNumber.Font = new Font("Segoe UI", 12F);
            txt_InvoiceNumber.Location = new Point(234, 119);
            txt_InvoiceNumber.Multiline = true;
            txt_InvoiceNumber.Name = "txt_InvoiceNumber";
            txt_InvoiceNumber.PlaceholderText = "Enter Number Invoice";
            txt_InvoiceNumber.Size = new Size(298, 34);
            txt_InvoiceNumber.TabIndex = 1;
            txt_InvoiceNumber.Click += txt_InvoiceNumber_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(85, 122);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 45;
            label1.Text = "Number Invoice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 19);
            label2.Name = "label2";
            label2.Size = new Size(163, 32);
            label2.TabIndex = 44;
            label2.Text = "Select Invoice";
            // 
            // pic_Close
            // 
            pic_Close.Image = (Image)resources.GetObject("pic_Close.Image");
            pic_Close.Location = new Point(600, 12);
            pic_Close.Name = "pic_Close";
            pic_Close.Size = new Size(35, 35);
            pic_Close.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Close.TabIndex = 46;
            pic_Close.TabStop = false;
            pic_Close.Click += pic_Close_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Transparent;
            btn_back.BackgroundImage = Properties.Resources.icons8_back_50;
            btn_back.BackgroundImageLayout = ImageLayout.Stretch;
            btn_back.Cursor = Cursors.Hand;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.ForeColor = SystemColors.ButtonFace;
            btn_back.ImageAlign = ContentAlignment.MiddleLeft;
            btn_back.Location = new Point(9, 233);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(54, 47);
            btn_back.TabIndex = 57;
            btn_back.TextAlign = ContentAlignment.MiddleRight;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // frm_CheckInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(647, 292);
            Controls.Add(btn_back);
            Controls.Add(pic_Close);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btn_CheckInvoice);
            Controls.Add(txt_InvoiceNumber);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_CheckInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_CheckInvoice";
            ((System.ComponentModel.ISupportInitialize)pic_Close).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_CheckInvoice;
        private TextBox txt_InvoiceNumber;
        private Label label1;
        private Label label2;
        private PictureBox pic_Close;
        private Button btn_back;
    }
}