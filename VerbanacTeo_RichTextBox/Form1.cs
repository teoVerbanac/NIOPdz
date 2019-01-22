using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerbanacTeo_RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCitaj_Click(object sender, EventArgs e)
        {
            // poziv funkcije LoadFile() za učitavanje tekst dokumenta
            // u richTextBox
            RichTxtBoxMain.LoadFile(@"C:Tempproba.rtf");

        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            // poziv funkije Clear() za brisanje sadržaja richTextBox-a
            RichTxtBoxMain.Clear();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            // poziv funkcije SaveFile() za spremanje sadržaja richTextBox-a
            // u dokumentu, uz navodjenje točno određenog mjesta
            RichTxtBoxMain.SaveFile(@"C:Tempproba.rtf");
            MessageBox.Show("Tekst spremljen");
        }
        

        private void oProgramuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Naziv programa: Timer komponenta \nIme učenika: Teo \nPrezime učenika: Verbanac \nDatum izrade: 22.1.2019\nDavatelj licence dopušta umnožavanje, distribuiranje i priopćavanje djela javnosti. Zauzvrat primatelji licence moraju imenovanjem priznati i označiti izvornog autora.");

        }
    }
}

