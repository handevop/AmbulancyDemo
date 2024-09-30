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

namespace Ambulanta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string lijecnik = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Niste upisali sve podatke!");
                return;
            }

            string conn = Properties.Resources.connectionString;

            using (SqlConnection sqlcon = new SqlConnection(conn))
            {
                try
                {
                    string passw = EasyEncryption.MD5.ComputeMD5Hash(textBox2.Text.Trim());

                    string query = "SELECT * from Prijava where OIB = '" + textBox1.Text.Trim() + "' and Lozinka = '" + passw + "' ;";

                    SqlCommand cmd = new SqlCommand(query, sqlcon);

                    cmd.Connection.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lijecnik = textBox1.Text;
                        Form2 frm2 = new Form2(lijecnik);
                        frm2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Pogrešan OIB ili lozinka!");
                    }
                }
                catch
                {
                    MessageBox.Show("Prijava nije uspjela! Provjerite upisane podatke ili kontaktirajte admina!");
                }
            }
        }
    }
}
