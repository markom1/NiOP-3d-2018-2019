using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MijajlovicMarkoImageListKomponenta
{
  
    public partial class Form1 : Form
    {
        public int brojac = 1;

        public Form1()
        {
            InitializeComponent();
            // najprije se vidi prva slika u listi
            pictureBox1.Image = imageList1.Images[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // svakim klikom na dugme mijenja se slika u PictureBox-u
            // nakon promjene, brojac se povecava za jedan

            if (brojac % 2 == 0)
                pictureBox1.Image = imageList1.Images[0];
            else
                pictureBox1.Image = imageList1.Images[1];
            brojac++;
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreativeCommonsLicense oProgramu = new CreativeCommonsLicense();
            oProgramu.Show();
        }
    }
}
