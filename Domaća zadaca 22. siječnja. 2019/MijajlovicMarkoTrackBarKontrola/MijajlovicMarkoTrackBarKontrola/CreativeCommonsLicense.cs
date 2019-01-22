using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MijajlovicMarkoTrackBarKontrola
{
    public partial class CreativeCommonsLicense : Form
    {
        public CreativeCommonsLicense()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            //Zatvara prozor koji govori o programu.

            this.Close();
        }

        private void linkLabelCreativeCommons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Label koji vodi na link unutar zagrada.

            System.Diagnostics.Process.Start("https://creativecommons.org/licenses/by-nc-sa/4.0/");
        }
    }
}
