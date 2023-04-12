using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionString = "Server=LAPTOP-EFP6IB7A;Initial Catalog=data;Integrated Security=True";
        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM dataguru WHERE is_deleted = 'false';", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;

                DataGridViewButtonColumn buttoncolum = new DataGridViewButtonColumn();
                dataGridView1.Columns.Insert(6, buttoncolum);
                //buttoncolum.Width = 77;
                buttoncolum.HeaderText = "Delete";
                buttoncolum.Text = "Delete";
                buttoncolum.UseColumnTextForButtonValue = true;


                DataGridViewButtonColumn buttoncolumn = new DataGridViewButtonColumn();
                dataGridView1.Columns.Insert(7, buttoncolumn);
                buttoncolumn.HeaderText = "Update";
                buttoncolumn.Text = "Update";
                buttoncolumn.UseColumnTextForButtonValue = true;

               
                Fresh();
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new insert().Show();
            Fresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM dataguru WHERE is_deleted = 'false';", conn);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;
                Fresh();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new update().Show();
            Fresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                if(e.ColumnIndex == 6)
                {
                    string query = "UPDATE dataguru SET is_deleted = 1  WHERE nip = @nip";


                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nip", dataGridView1.Rows[e.RowIndex].Cells["nip"].Value.ToString());
                    
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Fresh();

                }
                if (e.ColumnIndex == 7)
                {
                    new update().Show();
                }
                            
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new delete().Show();
        }

        private void Refreshh_Click(object sender, EventArgs e)
        {

        }

        public void Fresh()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT total FROM totall";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                int jml = (int)command.ExecuteScalar();
                conn.Close();

                jumlah.Text = jml.ToString();

                conn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM dataguru WHERE is_deleted = 'false';", conn);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
