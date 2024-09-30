using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Microsoft.CodeAnalysis;
using System.Windows.Documents;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using iTextSharp;
using ConvertApiDotNet;
using System.IO;

namespace Ambulanta
{
    public partial class Form2 : Form
    {
        string Lijecnik = string.Empty;
        public Form2(string lijecnik)
        {
            InitializeComponent();
            Lijecnik = lijecnik;
        }

        Form3 f3;
        Form4 f4;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void exportAsPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Rectangle bounds = this.Bounds;
                bounds.Location = new Point(this.Location.X + 10, this.Location.Y);
                bounds.Size = new Size(this.Size.Width - 20, this.Size.Height - 10);

                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size, CopyPixelOperation.SourceCopy);
                    }
                    bitmap.Save("C://Intel/forma.jpg", ImageFormat.Jpeg);
                }
            }
            catch
            {
                MessageBox.Show("Nije uspjelo spremanje!");
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        int bio3 = 0;
        int bio4 = 0;
        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bio4 == 1) f4.Hide();
            bio3 = 1;
            bio4 = 0;
            f3 = new Form3(Lijecnik);
            f3.TopLevel = false;
            f3.Parent = this;
            f3.Show();
        }

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bio3 == 1) f3.Hide();
            bio3 = 0;
            bio4 = 1;
            f4 = new Form4(Lijecnik);
            f4.TopLevel = false;
            f4.Parent = this;
            for (int i = 2; i < Application.OpenForms.Count; i++)
            {
                Application.OpenForms[i].Hide();
            }
            f4.Show();
        }
    }
}
