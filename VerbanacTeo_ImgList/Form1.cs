using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerbanacTeo_ImgList
{
    public partial class Form1 : Form
    {
        public int brojac = 1;
        public Form1()
        {
            InitializeComponent();
            // u startu ce biti vidljiva prva slika u listi
            pictureBox1.Image = imageList1.Images[0];
        }
        
        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Naziv programa: ImageList \nIme učenika: Teo \nPrezime učenika: Verbanac \nDatum izrade: 22.1.2019\nDavatelj licence dopušta umnožavanje, distribuiranje i priopćavanje djela javnosti. Zauzvrat primatelji licence moraju imenovanjem priznati i označiti izvornog autora.");
        }

        private void btnMijenjaj_Click_1(object sender, EventArgs e)
        {
            
               // svakim klikom na dugme mijenja se slika u PictureBox-u
               // nakon te promjene, brojac se uvecava za 1
               if (brojac % 2 == 0)
                    pictureBox1.Image = imageList1.Images[0];
               else
                    pictureBox1.Image = imageList1.Images[1];
               brojac++;
            
        }
    }
}
