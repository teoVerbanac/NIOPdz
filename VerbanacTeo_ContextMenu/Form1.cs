﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerbanacTeo_ContextMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lijevoNaDesnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt2.Text = txt1.Text;
        }

        private void desnoNaLijevoCtrlLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt1.Text = txt2.Text;
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Naziv programa: ContexMenu Strip Komponenta \nIme učenika: Teo \nPrezime učenika: Verbanac \nDatum izrade: 22.1.2019\nDavatelj licence dopušta umnožavanje, distribuiranje i priopćavanje djela javnosti. Zauzvrat primatelji licence moraju imenovanjem priznati i označiti izvornog autora.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
