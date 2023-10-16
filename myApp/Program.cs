/*using System;
using System.Globalization;

namespace myApp 
 Person p = new Person("Wassim", "Bachar", "m", "Scandiano", "21/01/2005");

Console.WriteLine(person.calcolaAnni());

Console.ReadLine();



    */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myApp;

namespace CodiceFiscaleCmdLine
{
    class Program
    {
        static void Main(string[] args)
        {
            CodiceFiscale cf = null;
            Console.WriteLine("1) Genera codice fiscale");
            Console.WriteLine("2) Ottieni dati da codice fiscale");
            Console.Write("Scelta > ");
            ConsoleKeyInfo input = Console.ReadKey();
            Console.Write("\n");
            if (input.KeyChar == '1')
            {

                //cf = new CodiceFiscale(Cognome, Nome, Sesso, Nascita, Comune, Provincia, LivelloOmocodia);
                Person p1 = new Person("Wassim", "Bachar", "m", "Scandiano", "21/01/2005");
                cf = new CodiceFiscale(p1.secondName, p1.firstName, p1.gender, DateTime.ParseExact(p1.birthDate, "dd/mm/yyyy", CultureInfo.InvariantCulture), p1.birthCity, "RE");
            }
            else if (input.KeyChar == '2')
            {
                Console.Write("Inserisci il codice fiscale > ");
                cf = new CodiceFiscale(Console.ReadLine());
            }
            foreach (var prop in cf.GetType().GetProperties())
            {
                Console.WriteLine("{0}={1}", prop.Name, prop.GetValue(cf, null));
            }
            Console.WriteLine("Premi un tasto per uscire...");
            Console.ReadKey();
        }
    }
}

