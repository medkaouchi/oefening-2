using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Getal : ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{a} x {i} = {a*i}");
            }
            Console.ReadLine();
        }
    }
}
