using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fahrenheit : ");
            double fahr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Celsius : {0}", ((fahr - 32) * 5 / 9).ToString("0.##"));
            Console.ReadLine();
        }
    }
}
