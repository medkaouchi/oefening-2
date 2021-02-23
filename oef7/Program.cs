using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Getal1 : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Getal2 : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Getal3 : ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("{0} - {1} - {2}",a,b,c);
            Console.WriteLine("{0} - {1} - {2}", a, c, b);
            Console.WriteLine("{0} - {1} - {2}", b, a, c);
            Console.WriteLine("{0} - {1} - {2}", b, c, a);
            Console.WriteLine("{0} - {1} - {2}", c, a, b);
            Console.WriteLine("{0} - {1} - {2}", c, b, a);
            Console.ReadLine();
        }
    }
}
