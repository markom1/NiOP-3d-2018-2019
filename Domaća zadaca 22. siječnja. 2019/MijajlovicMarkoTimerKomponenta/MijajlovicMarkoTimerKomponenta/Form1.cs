using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MijajlovicMarkoTimerKomponenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Timer se pokrece cim se otvori program
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // upis trenutnog vremena u label kontroli
            labelVrijeme.Text = DateTime.Now.ToShortTimeString();
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreativeCommonsLicense oProgramu = new CreativeCommonsLicense();
            oProgramu.Show();
        }
    }
}
