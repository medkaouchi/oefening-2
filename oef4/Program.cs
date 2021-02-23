using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Voornaam: ");
            string voornaam = Console.ReadLine();
            Console.Write("Naam: ");
            string naam = Console.ReadLine();
            Console.Write("Adres: ");
            string adres = Console.ReadLine();
            Console.Write("Huisnummer: ");
            string huisnummer = Console.ReadLine();
            Console.Write("Postcode: ");
            string postcode = Console.ReadLine();
            Console.Write("Stad: ");
            string stad = Console.ReadLine();

            //Console.WriteLine($"Jij bent {voornaam} {naam}. Je woont in {adres} {huisnummer}, {postcode} {stad}.");
            Console.WriteLine("Jij bent " + voornaam + " " + naam + ". Je woont in " + adres + " " + huisnummer + ", " + postcode + " " + stad + ".");
            Console.ReadLine();
        }
    }
}
