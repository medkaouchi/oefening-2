using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("getal 1 : ");
            double get1 = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("getal 2 : ");
            double get2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Als je {0} deelt door {1}, dan is de rest {2}",get1,get2,(get1%get2).ToString("0.##"));
            Console.ReadLine();
        }
    }
}
