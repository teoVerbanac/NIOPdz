using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using klaseAndObjekti.Klase;

namespace klaseAndObjekti
{
    class Program
    {
        static void Main(string[] args)
        {

        
            Vozilo ime = new Vozilo();
            bool jos = true;
            
            do
            {
                Console.WriteLine("Kojoj vrsti pripada:");
                ime.setVrsta(Console.ReadLine().ToString());
                Console.WriteLine("Broj kotača(ako nema napšite 0)");
                ime.setBrojKotaca(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Kreće se po zraku(true/false):");
                ime.setLeti(bool.Parse(Console.ReadLine()));
                Console.WriteLine("Kreće se po vodi(true/false):");
                ime.setPliva(bool.Parse(Console.ReadLine()));
                Console.WriteLine("Kreće se po kopnu(true/false):");
                ime.setVozi(bool.Parse(Console.ReadLine()));
                Console.WriteLine("Registracija");
                ime.setOznaka(Console.ReadLine().ToString());

                Console.WriteLine(ime.ispis());

                Console.WriteLine("Želite li upisati još neko vozilo?(true/false)");
                jos = bool.Parse(Console.ReadLine());
            } while (jos == true);

            /*
            Vozilo kamijon = new Vozilo(8, false, false, true, "TAM", "RI1987AR");
            Console.WriteLine("Vrsta: " + ime.getVrsta() + " Oznaka: " +
                ime.getOznaka() + "\nLeti: " + ime.getLeti() + "\nPlovi: "+ ime.getPliva()
                + "\nVozi: " + ime.getVozi() + "\nBroj kotača: "+ime.getBrojKotaca() + "\n");
            
            Console.WriteLine(kamijon.ToString());
            */

            Console.ReadLine();
        }
    }


}
    

