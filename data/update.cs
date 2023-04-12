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
    public partial class update : Form
    {
        string connectionString = "Server=LAPTOP-EFP6IB7A;Initial Catalog=data;Integrated Security=True";
        public update()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand command = new SqlCommand("Update dataguru set nip=@nip, nama_guru=@nama_guru, ttl=@ttl, jenis_kelamin=@jenis_kelamin, mapel=@mapel, gaji=@gaji, updated_at=@updated_at where id=@id", sqlCon);               
                command.Parameters.AddWithValue("@nip", niptext.Text);
                command.Parameters.AddWithValue("@nama_guru", namatext.Text);
                command.Parameters.AddWithValue("@ttl", ttltext.Text);
                if (radioButton1.Checked == true)
                {
                    command.Parameters.AddWithValue("@jenis_kelamin", "L");

                }
                if (radioButton2.Checked == true)
                {
                    command.Parameters.AddWithValue("@jenis_kelamin", "P");
                }

                command.Parameters.AddWithValue("@mapel", mapeltext.Text);
                command.Parameters.AddWithValue("@gaji", gajitext.Text);
                command.Parameters.AddWithValue("@updated_at", DateTime.Now);

                //niptext.Text = dataGridView1.Rows[e.RowIndex].Cells["nama_kolom"].Value.ToString();
                /*niptext.Text = command.Parameters["@nip"].Value.ToString();
                command.Parameters["@nama_guru"].Value = namatext.Text;
                command.Parameters["@id"].Value = id;*/

                
                command.ExecuteNonQuery();  
                sqlCon.Close();
                MessageBox.Show("data updated");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
