using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Devices;
using ProjectEntity_Dapper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEntity_Dapper.Products
{
    public partial class frm_category : Form
    {
        SqlConnection con;
        public frm_category()
        {
            InitializeComponent();

            con = new SqlConnection("Server=DESKTOP-8JFRNPP\\SQLEXPRESS;Database=Warehouse;Trusted_Connection=True;Trust Server Certificate= True");

        }

        private void Category_Load(object sender, EventArgs e)
        {

            var q4 = con.Query<Category>("select * from Category ").ToList();

            dgv_category.DataSource = q4;
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            var query = "insert into Category values(@Name)";

            var name = txt_Catname.Text;


            var q1 = con.Execute(query, new { Name = name });

            if (q1 > 0)
            {

                txt_Catname.Text = "";



                dgv_category.DataSource = con.Query<Category>("select * from Category ").ToList();
                MessageBox.Show("done");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {


            var query = $"Update Category Set Name=@name where Id={id} ";

            var name = txt_Catname.Text;

            var q1 = con.Execute(query, new { name = name });

            if (q1 > 0)
            {

                txt_Catname.Text = "";



                dgv_category.DataSource = con.Query<Category>("select * from Category ").ToList();
                MessageBox.Show("done");
            }
            else
            {
                MessageBox.Show("Error");
            }


        }
        int id;
        private void dgv_category_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_category.SelectedRows[0].Cells[0].Value;
            var query = $"select * from Category where Id ={id} ";
            var s1 = con.QueryFirstOrDefault<frm_category>(query);
            if (s1 != null)
            {

                txt_Catname.Text = s1.Name;

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var query = $"Delete From Category where Id={id} ";



            var q1 = con.Execute(query);

            if (q1 > 0)
            {



                dgv_category.DataSource = con.Query<Category>("select * from Category ").ToList();
                MessageBox.Show("Delete Done");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Catname.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
