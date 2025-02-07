using ProjectEntity_Dapper.Products_Form;

namespace ProjectEntity_Dapper.user
{
    partial class frm_userList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_userList));
            pic_Close = new PictureBox();
            dgvUserList = new DataGridView();
            txt_search = new TextBox();
            label2 = new Label();
            btn_Create = new Button();
            label1 = new Label();
            btn_refrsh = new Button();
            txt_username = new TextBox();
            label4 = new Label();
            txt_mail = new TextBox();
            lbl_ProdName = new Label();
            btn_back = new Button();
            btn_save = new Button();
            btn_delete = new Button();
            cmbo_role = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_Close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUserList).BeginInit();
            SuspendLayout();
            // 
            // pic_Close
            // 
            pic_Close.Image = Properties.Resources.icons8_close_48;
            pic_Close.Location = new Point(960, 6);
            pic_Close.Name = "pic_Close";
            pic_Close.Size = new Size(35, 35);
            pic_Close.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Close.TabIndex = 1;
            pic_Close.TabStop = false;
            pic_Close.Click += pic_Close_Click;
            // 
            // dgvUserList
            // 
            dgvUserList.BackgroundColor = Color.FromArgb(0, 64, 64);
            dgvUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserList.Location = new Point(453, 115);
            dgvUserList.Name = "dgvUserList";
            dgvUserList.Size = new Size(556, 534);
            dgvUserList.TabIndex = 2;
            dgvUserList.CellContentClick += dgvUserList_CellContentClick;
            dgvUserList.RowHeaderMouseDoubleClick += dgvUserList_RowHeaderMouseDoubleClick;
            // 
            // txt_search
            // 
            txt_search.Font = new Font("Segoe UI", 12F);
            txt_search.Location = new Point(535, 77);
            txt_search.Multiline = true;
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = "Write  User Name ....";
            txt_search.Size = new Size(278, 32);
            txt_search.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(107, 32);
            label2.TabIndex = 38;
            label2.Text = "User List";
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
            btn_Create.Location = new Point(819, 71);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(128, 43);
            btn_Create.TabIndex = 2;
            btn_Create.Text = "Search";
            btn_Create.TextAlign = ContentAlignment.MiddleLeft;
            btn_Create.UseVisualStyleBackColor = false;
            btn_Create.Click += btn_Create_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(453, 83);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 39;
            label1.Text = "Search ";
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
            btn_refrsh.Location = new Point(953, 71);
            btn_refrsh.Name = "btn_refrsh";
            btn_refrsh.Size = new Size(46, 43);
            btn_refrsh.TabIndex = 40;
            btn_refrsh.TextAlign = ContentAlignment.MiddleLeft;
            btn_refrsh.UseVisualStyleBackColor = false;
            btn_refrsh.Click += btn_refrsh_Click;
            // 
            // txt_username
            // 
            txt_username.Enabled = false;
            txt_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(160, 185);
            txt_username.MaximumSize = new Size(240, 50);
            txt_username.MinimumSize = new Size(240, 35);
            txt_username.Name = "txt_username";
            txt_username.PlaceholderText = "Write User Name Here......";
            txt_username.Size = new Size(240, 35);
            txt_username.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(28, 199);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 52;
            label4.Text = "User Name";
            // 
            // txt_mail
            // 
            txt_mail.Enabled = false;
            txt_mail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_mail.Location = new Point(160, 122);
            txt_mail.MaximumSize = new Size(240, 50);
            txt_mail.MinimumSize = new Size(240, 35);
            txt_mail.Name = "txt_mail";
            txt_mail.PlaceholderText = "Write Email Here......";
            txt_mail.Size = new Size(240, 35);
            txt_mail.TabIndex = 41;
            // 
            // lbl_ProdName
            // 
            lbl_ProdName.AutoSize = true;
            lbl_ProdName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ProdName.ForeColor = Color.White;
            lbl_ProdName.Location = new Point(28, 125);
            lbl_ProdName.Name = "lbl_ProdName";
            lbl_ProdName.Size = new Size(48, 21);
            lbl_ProdName.TabIndex = 47;
            lbl_ProdName.Text = "Email";
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
            btn_back.Location = new Point(12, 488);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(144, 50);
            btn_back.TabIndex = 56;
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
            btn_save.Location = new Point(286, 329);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(114, 52);
            btn_save.TabIndex = 4;
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
            btn_delete.Location = new Point(160, 329);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(115, 50);
            btn_delete.TabIndex = 5;
            btn_delete.Text = "Delete";
            btn_delete.TextAlign = ContentAlignment.MiddleLeft;
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // cmbo_role
            // 
            cmbo_role.Font = new Font("Segoe UI", 12F);
            cmbo_role.FormattingEnabled = true;
            cmbo_role.Items.AddRange(new object[] { "User", "Admin" });
            cmbo_role.Location = new Point(160, 257);
            cmbo_role.Name = "cmbo_role";
            cmbo_role.Size = new Size(240, 29);
            cmbo_role.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(28, 265);
            label5.Name = "label5";
            label5.Size = new Size(43, 21);
            label5.TabIndex = 61;
            label5.Text = "Role";
            // 
            // frm_userList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1007, 546);
            Controls.Add(label5);
            Controls.Add(cmbo_role);
            Controls.Add(btn_delete);
            Controls.Add(btn_back);
            Controls.Add(btn_save);
            Controls.Add(txt_username);
            Controls.Add(label4);
            Controls.Add(txt_mail);
            Controls.Add(lbl_ProdName);
            Controls.Add(btn_refrsh);
            Controls.Add(label1);
            Controls.Add(btn_Create);
            Controls.Add(label2);
            Controls.Add(txt_search);
            Controls.Add(dgvUserList);
            Controls.Add(pic_Close);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_userList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product_List";
            Load += List_User_Load;
            ((System.ComponentModel.ISupportInitialize)pic_Close).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUserList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_Close;
        private DataGridView dgvUserList;
        private TextBox txt_search;
        private Label label2;
        private Button btn_Create;
        private Label label1;
        private Button btn_refrsh;
        private TextBox txt_username;
        private Label label4;
        private TextBox txt_mail;
        private Label lbl_ProdName;
        private Button btn_back;
        private Button btn_save;
        private Button btn_delete;
        private ComboBox cmbo_role;
        private Label label5;
    }
}