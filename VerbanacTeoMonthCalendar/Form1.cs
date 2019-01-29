using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerbanacTeoMonthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTermin_Click(object sender, EventArgs e)
        {
            // objektu klase TimeSpan dodjeljuje se izabrani broj dana
            TimeSpan ts = monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart ;
            // u slučaju da korisnik nije izabrao termin, pokreće se message box
            // sa odgovarajucom porukom
            if (ts.Days < 1)
            {
                MessageBox.Show("Korištenjem tipke SHIFT odaberite opseg datuma.");
                return;
            }
            // poruka o izabranom broju dana
            MessageBox.Show("Rezervirali ste usluge u trajanju od " + ts.Days.ToString() + " dana.", "Rezervacija");
            // poruka o izabranim datumima pocetka i kraja rezervacije
            MessageBox.Show("Vasa rezervacija počinje " + monthCalendar1.SelectionStart.ToLongDateString() + " a završava se " + monthCalendar1.SelectionEnd.ToLongDateString());


        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Naziv programa: MonthCalendar \nIme učenika: Teo \nPrezime učenika: Verbanac \nDatum izrade: 29.1.2019\nDavatelj licence dopušta umnožavanje, distribuiranje i priopćavanje djela javnosti. Zauzvrat primatelji licence moraju imenovanjem priznati i označiti izvornog autora.");
        }
    }
}
