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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Server =DESKTOP-CBPUU0G; Database = eşleştirmeDB; Trusted_Connection = True");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, password;
            name= textBox1.Text;
            password = textBox2.Text;

                

            try
            {
                string sorgu = "SELECT * FROM users where name = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sorgu, conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    name = textBox1.Text;
                    password = textBox2.Text;

                    new Form1().Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("username or password is wrong");
                   textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
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

        private void button2_Click(object sender, EventArgs e)
        {
            new register().Show();
        }
    }
}
