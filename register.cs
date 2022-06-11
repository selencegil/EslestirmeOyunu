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
using System.Configuration;

namespace EslestirmeOyunu1
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CBPUU0G;Initial Catalog=eşleştirmeDB;Integrated Security=True");
            try
            {
                SqlCommand cmd = new SqlCommand("insert into users(name,Eposta,phone,password) values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')", conn);


                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("sucsesfully");

                new Form1().Show();
            }
            catch
            {
                MessageBox.Show("an error occured");
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
