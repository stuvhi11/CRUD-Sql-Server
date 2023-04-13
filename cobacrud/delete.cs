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

namespace cobacrud
{
    public partial class delete : Form
    {
        string connectionString = "Server=LAPTOP-EFP6IB7A;Initial Catalog=data;Integrated Security=True";
        public delete()
        {
            InitializeComponent();
        }


        private void delete_Load(object sender, EventArgs e)
        {
            tampil();
        }

        public void tampil()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM dataguru WHERE is_Deleted = 'true';", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE dataguru SET is_deleted = '0', updated_at = GETDATE() WHERE is_deleted=1 AND NOT nip IN (SELECT nip FROM dataguru WHERE is_deleted=0)";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                int jumlsmph = dataGridView1.Rows.Count;
                sqlCon.Open();
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                int sisa = dataGridView1.Rows.Count;
                int bhs = jumlsmph - sisa;
                MessageBox.Show($"{"Data berhasil di pulihkan "}{sisa}\n{"Data gagal dipulihkan "}{bhs}");
                tampil();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
                tampil();
            }
        }
    }
}
