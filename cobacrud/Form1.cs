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
using VPaged.WF;


namespace cobacrud
{
    public partial class sidebg : Form
    {
        string connectionString = "Server=LAPTOP-EFP6IB7A;Initial Catalog=data;Integrated Security=True";
        int itemsPerPage = 5;
        int currentPage = 1;


        public sidebg()
        {
            InitializeComponent();
            //start = 0;

        }

        private void restore_Click(object sender, EventArgs e)
        {
            delete form2 = new delete();
            form2.ShowDialog();
            fresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                //SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM dataguru WHERE is_deleted = 'false';", conn);
                //DataSet ds = new DataSet();

                //sqlDa.Fill(ds, start, 5, "dataguru");

                //tampil.DataSource = ds.Tables[0];

                //back.Enabled = false;

            }
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

            
                // Mengambil data pada halaman pertama dan menampilkannya pada DataGridView
                DataTable dt = GetData(currentPage);
                tampil.DataSource = dt;

                // Menghitung jumlah halaman total dan mengisikan ComboBox dengan nomor halaman
                int totalPages = CalculateTotalPages();
                for (int i = 1; i <= totalPages; i++)
                {
                    comboBox1.Items.Add(i);
                }
                comboBox1.SelectedIndex = currentPage - 1;
            

            //ngitung();
            //tampilan();
        //fresh();
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
            //fresh();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = comboBox1.SelectedIndex + 1;
            DataTable dt = GetData(currentPage);
            tampil.DataSource = dt;
        }

        

        private DataTable GetData(int page)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query2 = "SELECT total FROM totall";
                SqlCommand command = new SqlCommand(query2, conn);
                conn.Open();
                int jml = (int)command.ExecuteScalar();
                conn.Close();

                jumlah.Text = jml.ToString();

                // Menghitung indeks awal dan akhir dari data pada halaman yang ditentukan
                int startIndex = (page - 1) * itemsPerPage;
                int endIndex = startIndex + itemsPerPage - 1;

                // Membuat query untuk mengambil data pada halaman yang ditentukan
                string query = $"SELECT * FROM dataguru ORDER BY id OFFSET {startIndex} ROWS FETCH NEXT {itemsPerPage} ROWS ONLY";

                // Mengeksekusi query dan mengambil hasilnya
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tampil.AutoGenerateColumns = false;
                tampil.DataSource = dt;

                return dt;
            }
        }

        private int CalculateTotalPages()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();
                // Menghitung jumlah total data
                string countQuery = "SELECT COUNT(*) FROM dataguru";
                SqlCommand countCmd = new SqlCommand(countQuery, conn);
                int totalItems = (int)countCmd.ExecuteScalar();
                jumlah.Text = totalItems.ToString();

                // Menghitung jumlah halaman total
                int totalPages = (int)Math.Ceiling((double)totalItems / itemsPerPage);
                label4.Text = totalPages.ToString();


                return totalPages;
                conn.Close();
            }
        }

    }
}




