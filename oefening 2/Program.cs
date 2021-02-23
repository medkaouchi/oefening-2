using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prijs drankje : ");
            double prijs =Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Aantal drankjes : ");
            int aantal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prijs zonder BTW : {0}",prijs*aantal);
            Console.WriteLine("Prijs met 21% BTW : {0}", prijs * aantal*79/100);
            Console.ReadLine();
        }
    }
}
