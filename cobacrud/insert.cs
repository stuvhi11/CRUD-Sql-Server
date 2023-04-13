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
    public partial class insert : Form
    {
        string connectionString = "Server=LAPTOP-EFP6IB7A;Initial Catalog=data;Integrated Security=True";
        public insert()
        {
            InitializeComponent();
        }

        private void insert_Load(object sender, EventArgs e)
        {
            
        }
    
        

        public void tambah()
        {
            
                
            
        }

        private void prm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            string nip = nimtext.Text;
            string querycek = $"SELECT COUNT(*) FROM dataguru WHERE nip = '{nip}'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    SqlCommand cek = new SqlCommand(querycek, conn);
                    int count = (int)cek.ExecuteScalar();
                    if (count == 0)
                    {
                        SqlCommand cmd = new SqlCommand("insert into dataguru (nip, nama_guru, jenis_kelamin, ttl, mapel, gaji, is_deleted, created_at) values (@nip, @nama, @jenis_kelamin, @tanggal_lahir, @mata_pelajaran, @gaji, @is_deleted, @created_at);", conn);
                        cmd.Parameters.AddWithValue("@nip", nimtext.Text);
                        cmd.Parameters.AddWithValue("@nama", namatext.Text);
                        if (lklk.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@jenis_kelamin", "L");

                        }
                        if (prm.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@jenis_kelamin", "P");
                        }
                        cmd.Parameters.AddWithValue("@tanggal_lahir", datetext.Text);
                        cmd.Parameters.AddWithValue("@mata_pelajaran", mapeltext.Text);
                        cmd.Parameters.AddWithValue("@gaji", gajitext.Text);
                        cmd.Parameters.AddWithValue("@is_deleted", 0);
                        cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data berhasil ditambahkan");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("NIP telah terdaftar", "warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }




            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

