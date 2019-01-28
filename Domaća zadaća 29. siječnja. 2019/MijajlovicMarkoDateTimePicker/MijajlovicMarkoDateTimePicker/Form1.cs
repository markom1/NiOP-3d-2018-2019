using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MijajlovicMarkoDateTimePicker
{
    public partial class formRezervacijaLeta : Form
    {
        public formRezervacijaLeta()
        {
            InitializeComponent();
        }

        private void btnRezervacija_Click(object sender, EventArgs e)
        {
            rtxtLet.Clear();

            DateTime dtDatum = dateDatumLeta.Value;
            DateTime dtVrijeme = dateVrijemeLeta.Value;
            StringBuilder sBuilder = new StringBuilder();

            sBuilder.Append("Vaš datum leta je:\n");
            sBuilder.Append(dtDatum.ToShortDateString() + "\n");

            sBuilder.Append("Vaše vrijeme polaska:\n");
            sBuilder.Append(dtVrijeme.ToShortTimeString());

            rtxtLet.AppendText(sBuilder.ToString());
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreativeCommonsLicense oProgramu = new CreativeCommonsLicense();
            oProgramu.Show();
        }
    }
}
