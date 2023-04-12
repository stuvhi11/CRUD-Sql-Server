using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace data
{
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }

        string connectionString = "Server=LAPTOP-EFP6IB7A;Initial Catalog=data;Integrated Security=True";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM dataguru WHERE is_deleted = 'true';", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            fresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM dataguru WHERE is_deleted = 'true';", conn);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM dataguru WHERE is_deleted='true';";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                fresh();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                
                string query = "Update dataguru set is_deleted = 0  WHERE is_deleted='true' AND NOT nip IN (SELECT nip FROM dataguru WHERE is_deleted='false');";

                SqlCommand cmd = new SqlCommand(query, conn);
                int jumlsmph = dataGridView1.Rows.Count;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                int sisa = dataGridView1.Rows.Count;
                int bhs = jumlsmph - sisa;
                MessageBox.Show($"{"Data berhasil di pulihkan "}{sisa}\n{"Data gagal dipulihkan "}{bhs}");
                fresh();

            }
        }

        public void fresh()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM dataguru WHERE is_deleted = 'true';", conn);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;
            }
        }

       

    }

}
