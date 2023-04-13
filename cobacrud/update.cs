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
    public partial class update : Form
    {
            string connectionString = "Server=LAPTOP-EFP6IB7A;Initial Catalog=data;Integrated Security=True";
        public update(string nip, string nama_guru, string jenis_kelamin, string ttl, string mapel, string gaji)
        {
            InitializeComponent();
            
                nimtext.Text = nip;
                namatext.Text = nama_guru;
                if (jenis_kelamin == "L")
                {
                    lklk.Checked = true;

                }
                else if (jenis_kelamin == "P")
                {
                    prm.Checked = true;
                }
                datetext.Text = ttl;
                mapeltext.Text = mapel;
                gajitext.Text = gaji;
                
            
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
                        SqlCommand cmd = new SqlCommand("UPDATE dataguru SET nip=@nip, nama_guru=@nama, jenis_kelamin=@jenis, ttl=@tanggal_lahir, mapel=@mata_pelajaran, gaji=@gaji, updated_at=@uptatedAt;", conn);
                        cmd.Parameters.AddWithValue("@nip", nimtext.Text);
                        cmd.Parameters.AddWithValue("@nama", namatext.Text);
                        if (lklk.Checked == true)
                             {
                                   cmd.Parameters.AddWithValue("@jenis", "L");

                              }
                              if (prm.Checked == true)
                                {
                                    cmd.Parameters.AddWithValue("@jenis", "P");
                              }

                            cmd.Parameters.AddWithValue("@tanggal_lahir", datetext.Text);
                        cmd.Parameters.AddWithValue("@mata_pelajaran", mapeltext.Text);
                        cmd.Parameters.AddWithValue("@gaji", gajitext.Text);
                        //cmd.Parameters.AddWithValue("@is_deleted", 0);
                        cmd.Parameters.AddWithValue("@uptatedAt", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data berhasil diupdate");
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
    }
}
