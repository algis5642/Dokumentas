using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_nd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konverteris cm i m ir atvirksciai");
            Console.WriteLine("Pasirinkite cm i m : 1");
            Console.WriteLine("Pasirinkite m i cm : 2");
            var x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            { case 1:
                    Console.WriteLine("jus pasirinkote cm i m. Prasome ivesti cm");
                    var a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(a/100+  "metrai");
                    break;
                case 2:
                    Console.WriteLine("jus pasirinkote m i cm. Prasome ivesti m");
                    var b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(b * 100 + "centimetrai");
                    break;
                default:
                    Console.WriteLine("pasirinkimo nera");
                    break;


           } 
            Console.ReadKey();
        }
    }
}
