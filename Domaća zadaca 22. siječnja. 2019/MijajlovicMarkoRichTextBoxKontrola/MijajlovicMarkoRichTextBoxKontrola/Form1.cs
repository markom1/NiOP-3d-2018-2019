using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MijajlovicMarkoRichTextBoxKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            // spremanje sadrzaja rtxtBoxa u datoteku
            rtxtBox.SaveFile(@"C:Tempproba.rtf");
            MessageBox.Show("Tekst spremljen.");
        }

        private void btnCitaj_Click(object sender, EventArgs e)
        {
            // učitavanje teksta iz datoteke u rtxtBox
            rtxtBox.LoadFile(@"C:Tempproba.rtf");
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            // brisanje sadrzaja rtxtBoxa
            rtxtBox.Clear();
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreativeCommonsLicense oProgramu = new CreativeCommonsLicense();
            oProgramu.Show();
        }
    }
}
