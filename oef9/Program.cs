using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Af te leggen afstand in km : ");
            double afstand = Convert.ToDouble(Console.ReadLine());
            Console.Write("Snelheid in km/h : ");
            double snelheid = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"De vrachtwagen zal nog {(afstand / snelheid).ToString()} uur moeten rijden");
            DateTime dt= new DateTime(1899, 12, 30).AddHours(afstand/snelheid);
                Console.WriteLine(dt.ToLongTimeString());
            Console.ReadLine();
        }
    }
}
