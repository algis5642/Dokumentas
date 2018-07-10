using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_nd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sudetis : 1");
            Console.WriteLine("atimtis : 2");
            var x = Convert.ToInt32(Console.ReadLine());


            switch (x)
            {
                case 1:
                    Console.WriteLine("jus pasirinkote sudeti. Iveskite du skaicius");
                    var a = Convert.ToInt32(Console.ReadLine());
                    var b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(a + b);
                    break;
                case 2:
                    Console.WriteLine("jus pasirinkote atimti.Iveskite du skaicius");
                    var ab = Convert.ToInt32(Console.ReadLine());
                    var bb = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(ab - bb);
                    break;
                default:
                    Console.WriteLine("pasirinkimo nera");
                    break;
            }
            Console.ReadKey();
            }
    }
}
