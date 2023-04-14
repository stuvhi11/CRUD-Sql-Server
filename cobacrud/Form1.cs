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
    public partial class sidebg : Form
    {
        string connectionString = "Server=LAPTOP-EFP6IB7A;Initial Catalog=data;Integrated Security=True";
        
            public sidebg()
        {
            InitializeComponent();
        }

        private void restore_Click(object sender, EventArgs e)
        {
            delete form2 = new delete();
            form2.ShowDialog();
            fresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn buttoncolum = new DataGridViewButtonColumn();
            tampil.Columns.Insert(6, buttoncolum);
            //buttoncolum.Width = 77;
            buttoncolum.HeaderText = "Delete";
            buttoncolum.Text = "Delete";
            buttoncolum.UseColumnTextForButtonValue = true;


            DataGridViewButtonColumn buttoncolumn = new DataGridViewButtonColumn();
            tampil.Columns.Insert(7, buttoncolumn);
            buttoncolumn.HeaderText = "Update";
            buttoncolumn.Text = "Update";
            buttoncolumn.UseColumnTextForButtonValue = true;

            

            tampilan();
            fresh();
        }

        public void tampilan()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM dataguru WHERE is_deleted = 'false';", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                
                tampil.AutoGenerateColumns = false;
                tampil.DataSource = dtbl;

            }
        }

        public void fresh()
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

                tampil.AutoGenerateColumns = false;
                tampil.DataSource = dtbl;
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            fresh();
            searchtext.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void deleteData(String ID)
        {
            String query = "UPDATE dataguru SET is_deleted = 1, updated_at = GETDATE()  WHERE id = @id";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", ID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void tampil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string query = "UPDATE dataguru SET is_Deleted = @isDeleted, is_deleted_at = @deletedAt WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (e.ColumnIndex == 6)
                {
                    string query = "UPDATE dataguru SET is_deleted = 1, is_deleted_at=@deletedAt  WHERE nip = @nip";


                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nip", tampil.Rows[e.RowIndex].Cells["nip"].Value.ToString());
                    cmd.Parameters.AddWithValue("@deletedAt", DateTime.Now);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    fresh();
                }


                if (e.ColumnIndex == 7)
                {
                                                                           
                    update form4 = new update();
                    form4.ShowDialog();
                    fresh();
                }

            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            insert form3 = new insert();
            form3.ShowDialog();
            fresh();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string searchQuery = "SELECT * FROM dataguru WHERE nip LIKE '%' + @searchText + '%' OR nama_guru LIKE '%' + @searchText + '%' OR ttl LIKE '%' + @searchText + '%' OR gaji LIKE '%' + @searchText + '%' OR mapel LIKE '%' + @searchText + '%' OR jenis_kelamin LIKE '%' + @searchText + '%'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(searchQuery, conn);
                cmd.Parameters.AddWithValue("@searchText", searchtext.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                tampil.DataSource = table;
                int rowCount = tampil.RowCount;
                jumlah.Text = rowCount.ToString();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void restorepnl_Paint(object sender, PaintEventArgs e)
        {
            delete form2 = new delete();
            form2.ShowDialog();
            fresh();
        }

        private void side_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



