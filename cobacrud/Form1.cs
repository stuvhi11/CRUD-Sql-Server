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
        SqlConnection conn = new SqlConnection ("Server=LAPTOP-EFP6IB7A;Initial Catalog=data;Integrated Security=True");
        String connectionString = "Server=LAPTOP-EFP6IB7A;Initial Catalog=data;Integrated Security=True";
        int dataPagi = 8;
        


        public sidebg()
        {
            InitializeComponent();
            
            

        }
                
        private void Form1_Load(object sender, EventArgs e)
        {
            showPagi(1);
            indexPagi();
        }    

        private void show()
        {
            string query = "EXEC show";

            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            tampil.AutoGenerateColumns = false;
            tampil.DataSource = table;

            conn.Close();

        }

        private void allData()
        {
            conn.Open();
            string query = "SELECT total FROM totall";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) jumlah.Text = dr["total"].ToString();
            conn.Close();

        }

        private void showPagi(int page= 1)
        {
            int pages = (page - 1) * dataPagi;

            string query = $"SELECT * FROM dataguru WHERE is_deleted = 0 ORDER BY updated_at DESC OFFSET {pages} ROWS FETCH NEXT {dataPagi} ROWS ONLY;";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            tampil.AutoGenerateColumns = false;
            tampil.DataSource = table;

            conn.Close();

            allData();

        }

        private void indexPagi()
        {
            comboBox1.Text = "1";

            int jumlahGuru = 0;
            string query = "SELECT total FROM totall";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) jumlahGuru = Convert.ToInt32(reader["total"]);
            reader.Close();
            conn.Close();

            double totalPages = Math.Ceiling(Convert.ToDouble(jumlahGuru) / Convert.ToDouble(dataPagi));

            comboBox1.Items.Clear();
            for (int i = 1; i <= totalPages; i++)
            {
                comboBox1.Items.Add(i);
            }

            label4.Text = totalPages.ToString();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showPagi(Convert.ToInt32(comboBox1.SelectedItem));
        }
              
                
        private void tampil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            searchtext.Clear();
            showPagi(1);
            indexPagi();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void create_Click(object sender, EventArgs e)
        {
            insert form3 = new insert();
            form3.ShowDialog();
            comboBox1.Items.Clear();
            showPagi();
            indexPagi();
            
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

        private void restore_Click(object sender, EventArgs e)
        {
            delete form2 = new delete();
            form2.ShowDialog();
            indexPagi();
            showPagi(1);
            
        }

        private void restorepnl_Paint(object sender, PaintEventArgs e)
        {
            delete form2 = new delete();
            form2.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
                
        private void side_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                              
        private void tampil_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //if (tampil.Columns[e.ColumnIndex].Name == "buttonHapus")
            if (e.ColumnIndex == 6)
            {
                string query = "UPDATE dataguru SET is_deleted = 1, is_deleted_at = GETDATE()  WHERE nip = @nip";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nip", tampil.Rows[e.RowIndex].Cells["nip"].Value.ToString());

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                allData();
                showPagi(1);
                indexPagi();
            } else if (e.ColumnIndex == 7)
            {
                update form2 = new update();
                form2.ShowDialog();
                indexPagi();
                showPagi(1);
            }
                
                   

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}




        