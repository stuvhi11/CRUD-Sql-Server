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
    public partial class insert : Form
    {
        string connectionString = "Server=LAPTOP-EFP6IB7A;Initial Catalog=data;Integrated Security=True";
        public insert()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand command = new SqlCommand("INSERT INTO dataguru VALUES (@nip, @nama_guru, @ttl, @jenis_kelamin, @mapel, @gaji, @is_deleted, @created_at, @updated_at)", sqlCon);

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
                command.Parameters.AddWithValue("@is_deleted", false);
                command.Parameters.AddWithValue("@created_at", DateTime.Now);
                command.Parameters.AddWithValue("@updated_at", DateTime.Now);




                command.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("succes");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }
    }

}
