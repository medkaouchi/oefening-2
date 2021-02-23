using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom in Kenland!");
            Console.WriteLine("Prijs lijst :");
            Console.WriteLine("Volwassenen : 35 euro ");
            Console.WriteLine("Tieners : 25 euro ");
            Console.WriteLine("Kinderenen : 20 euro \n\n");
            Console.Write("Aantal volwassenen : ");
            int vol = Convert.ToInt32(Console.ReadLine());
            Console.Write("Aantal tieners : ");
            int tien = Convert.ToInt32(Console.ReadLine());
            Console.Write("Aantal kinderen : ");
            int kind = Convert.ToInt32(Console.ReadLine());
            int total = vol * 35 + tien * 25 + kind * 20;
            double _tien=0, _kind=0, _vol=0;
            double a = 35;
            for (int i = vol-1; i > 0; i--)
                {
                a = a + (a* 90 / 100);
                };
            if (vol>= 2)
                _vol = a;
            else
               if (vol == 1)
                _vol = vol;
            a = 25;
            for (int i = tien-1; i > 0; i--)
            {
                a = a + (a * 90 / 100);
            };
            if (tien >= 2)
                _tien = a;
            else
               if (tien == 1)
                _tien = tien;
            a = 20;
            for (int i = kind - 1; i > 0; i--)
            {
                a = a + (a * 90 / 100);
            };
            if (kind >= 2)
                _kind = a;
            else
                if (kind == 1)
                _kind = kind;
            Console.WriteLine("\n");
            Console.WriteLine($"Totaal : {_vol+_tien+_kind} euro");
            //extra 10% korting 
            Console.WriteLine($"Totaal : {_vol + _tien + _kind-(((vol*35)+(tien*25)+(kind*20))*0.1)} euro");
            Console.ReadLine();
            

        }
    }
}
