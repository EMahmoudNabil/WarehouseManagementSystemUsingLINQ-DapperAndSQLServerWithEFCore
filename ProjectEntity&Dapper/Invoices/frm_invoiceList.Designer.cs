using ProjectEntity_Dapper.Models;
using System.ComponentModel;

namespace ProjectEntity_Dapper.Invoices
{
    partial class frm_invoiceList
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
        private WarehouseDBContext dbContext;
        private PictureBox pictureBox2;
        private Label label1;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label2;
        private DataGridView dgvInvoices;
        private Button btnExportPDF;
        private Button btn_back;
        private string invoiceNumber;



        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_invoiceList));
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label2 = new Label();
            dgvInvoices = new DataGridView();
            btnExportPDF = new Button();
            btn_back = new Button();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)dgvInvoices).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_close_48;
            pictureBox2.Location = new Point(828, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(111, 92);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 48;
            label1.Text = "Number Invoice";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 64, 64);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ButtonFace;
            btnSearch.Image = Properties.Resources.icons8_search_48;
            btnSearch.ImageAlign = ContentAlignment.MiddleRight;
            btnSearch.Location = new Point(581, 83);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(164, 43);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = ContentAlignment.MiddleLeft;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.Location = new Point(260, 89);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter Number Invoice";
            txtSearch.Size = new Size(298, 34);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 17);
            label2.Name = "label2";
            label2.Size = new Size(135, 32);
            label2.TabIndex = 49;
            label2.Text = "List Invoice";
            // 
            // dgvInvoices
            // 
            dgvInvoices.BackgroundColor = Color.FromArgb(0, 64, 64);
            dgvInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoices.Location = new Point(114, 138);
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.Size = new Size(645, 338);
            dgvInvoices.TabIndex = 50;
            dgvInvoices.CellContentClick += dgvInvoices_CellContentClick;
            // 
            // btnExportPDF
            // 
            btnExportPDF.BackColor = Color.FromArgb(0, 64, 64);
            btnExportPDF.Cursor = Cursors.Hand;
            btnExportPDF.FlatAppearance.BorderSize = 0;
            btnExportPDF.FlatStyle = FlatStyle.Flat;
            btnExportPDF.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportPDF.ForeColor = SystemColors.ButtonFace;
            btnExportPDF.Image = (Image)resources.GetObject("btnExportPDF.Image");
            btnExportPDF.ImageAlign = ContentAlignment.MiddleRight;
            btnExportPDF.Location = new Point(701, 482);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(164, 57);
            btnExportPDF.TabIndex = 51;
            btnExportPDF.Text = "Export PDF";
            btnExportPDF.TextAlign = ContentAlignment.MiddleLeft;
            btnExportPDF.UseVisualStyleBackColor = false;
            btnExportPDF.Click += btnExportPDF_Click;
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
            btn_back.Location = new Point(25, 496);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(54, 47);
            btn_back.TabIndex = 58;
            btn_back.TextAlign = ContentAlignment.MiddleRight;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // frm_invoiceList
            // 
            BackColor = Color.Teal;
            ClientSize = new Size(877, 551);
            Controls.Add(btn_back);
            Controls.Add(btnExportPDF);
            Controls.Add(dgvInvoices);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_invoiceList";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frm_invoiceList_Load;
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)dgvInvoices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
    }
}