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
    public partial class Form4 : Form
    {
        string Lijecnik = string.Empty;
        public Form4(string lijecnik)
        {
            InitializeComponent();
            Lijecnik = lijecnik;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(Properties.Resources.connectionString))
            {
                string query = "Insert into Pregled(ID,ID_Lijecnik,ID_Dijagnoza,Datum_pregleda) values ( 0 ," +
                    "( Select ID from Lijecnik where OIB = '" + Lijecnik + "' ) , Select convert(int,(Select Count(*) from Dijagnoza )) + 1 , '"
                    + DateTime.Now.Date + "';";

                SqlCommand cmd = new SqlCommand(query, sqlcon);

                cmd.Connection.Open();

                cmd.ExecuteNonQuery();

                query = "Insert into Lijecenje(ID,Naziv_lijeka,ID_Dijagnoza,Datum_pregleda) values ( 0 , '" +
                    textBox3.Text.Trim() + "' , " + textBox4.Text.Trim() + " , Select convert(int,(Select Count(*) from Dijagnoza )) , '"
                    + dateTimePicker1.Value + "' , NULL );";

                cmd.ExecuteNonQuery();

                query = "Insert into Pregledi(ID,ID_Lijecnik , ID_Dijagnoza , Datum_pregleda) values " +
                    "(0, ( Select ID from Lijecnik where OIB = '" + Lijecnik + "' ) , Select convert(int,(Select Count(*) from Dijagnoza )) , '" +
                    DateTime.Now.Date + "' );";

                cmd.ExecuteNonQuery();

            }
        }
    }
}
