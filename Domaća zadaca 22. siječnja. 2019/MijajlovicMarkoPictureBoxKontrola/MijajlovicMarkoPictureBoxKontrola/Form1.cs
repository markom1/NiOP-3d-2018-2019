using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MijajlovicMarkoPictureBoxKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // klikom na gumb, slika postaje vidljiva
            pictureBox1.Visible = true;
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreativeCommonsLicense oProgramu = new CreativeCommonsLicense();
            oProgramu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
