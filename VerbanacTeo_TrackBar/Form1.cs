using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerbanacTeo_TrackBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtKlizac.Text = "0";
        }
        

        private void trackBarScroll_Scroll(object sender, EventArgs e)
        {
            // trackBar1.Value predstavlja tekucu vrijednost klizaca

            txtKlizac.Text = trackBarScroll.Value.ToString();

        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Naziv programa: Track Bar \nIme učenika: Teo \nPrezime učenika: Verbanac \nDatum izrade: 22.1.2019\nDavatelj licence dopušta umnožavanje, distribuiranje i priopćavanje djela javnosti. Zauzvrat primatelji licence moraju imenovanjem priznati i označiti izvornog autora.");

        }
    }
}
