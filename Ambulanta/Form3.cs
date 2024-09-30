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
using System.Globalization;

namespace Ambulanta
{
    public partial class Form3 : Form
    {
        public Form3(string lijecnik)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(Properties.Resources.connectionString))
            {
                string query = "Select Ime , Prezime , Datum_rodenja , Naziv_dijagnoze , Datum_uspostave , Naziv_lijeka , Kolicina , Datum_zavrsetka from Pacijent " +
                    " inner join Dijagnoza on Pacijent.ID = Dijagnoza.Pacijent_ID inner join " +
                    "Lijecenje on Dijagnoza.ID = Lijecenje.Dijagnoza_ID where Zdravstveno = 1 and Broj_zdravstvene = " + textBox1.Text.Trim() + "; ";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlcon);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}
