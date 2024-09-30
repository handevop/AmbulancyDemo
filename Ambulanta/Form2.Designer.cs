namespace Ambulanta
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacijentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.povijestBolestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.računiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brojPregledaPacijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brojPregledaDoktoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brojIzdanihLijekovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.pacijentToolStripMenuItem,
            this.računiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exportAsPDFToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exportAsPDFToolStripMenuItem
            // 
            this.exportAsPDFToolStripMenuItem.Name = "exportAsPDFToolStripMenuItem";
            this.exportAsPDFToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exportAsPDFToolStripMenuItem.Text = "Export";
            this.exportAsPDFToolStripMenuItem.Click += new System.EventHandler(this.exportAsPDFToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // pacijentToolStripMenuItem
            // 
            this.pacijentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem,
            this.pregledToolStripMenuItem,
            this.povijestBolestiToolStripMenuItem});
            this.pacijentToolStripMenuItem.Name = "pacijentToolStripMenuItem";
            this.pacijentToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pacijentToolStripMenuItem.Text = "Pacijent";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pregledToolStripMenuItem.Text = "Pregled";
            this.pregledToolStripMenuItem.Click += new System.EventHandler(this.pregledToolStripMenuItem_Click);
            // 
            // povijestBolestiToolStripMenuItem
            // 
            this.povijestBolestiToolStripMenuItem.Name = "povijestBolestiToolStripMenuItem";
            this.povijestBolestiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.povijestBolestiToolStripMenuItem.Text = "Povijest bolesti";
            // 
            // računiToolStripMenuItem
            // 
            this.računiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brojPregledaPacijentaToolStripMenuItem,
            this.brojPregledaDoktoraToolStripMenuItem,
            this.brojIzdanihLijekovaToolStripMenuItem});
            this.računiToolStripMenuItem.Name = "računiToolStripMenuItem";
            this.računiToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.računiToolStripMenuItem.Text = "Računi";
            // 
            // brojPregledaPacijentaToolStripMenuItem
            // 
            this.brojPregledaPacijentaToolStripMenuItem.Name = "brojPregledaPacijentaToolStripMenuItem";
            this.brojPregledaPacijentaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.brojPregledaPacijentaToolStripMenuItem.Text = "Broj pregleda pacijent";
            // 
            // brojPregledaDoktoraToolStripMenuItem
            // 
            this.brojPregledaDoktoraToolStripMenuItem.Name = "brojPregledaDoktoraToolStripMenuItem";
            this.brojPregledaDoktoraToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.brojPregledaDoktoraToolStripMenuItem.Text = "Broj pregleda doktor";
            // 
            // brojIzdanihLijekovaToolStripMenuItem
            // 
            this.brojIzdanihLijekovaToolStripMenuItem.Name = "brojIzdanihLijekovaToolStripMenuItem";
            this.brojIzdanihLijekovaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.brojIzdanihLijekovaToolStripMenuItem.Text = "Broj izdanih lijekova";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacijentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem povijestBolestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem računiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brojPregledaPacijentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brojPregledaDoktoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brojIzdanihLijekovaToolStripMenuItem;
    }
}