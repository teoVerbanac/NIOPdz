using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerbanacTeo_PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            // pritiskom na dugme, slika postaje vidljiva za korisnika
            pictureBox1.Visible = true;
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Naziv programa: Picture Box \nIme učenika: Teo \nPrezime učenika: Verbanac \nDatum izrade: 22.1.2019\nDavatelj licence dopušta umnožavanje, distribuiranje i priopćavanje djela javnosti. Zauzvrat primatelji licence moraju imenovanjem priznati i označiti izvornog autora.");
        }

        
    }
}
