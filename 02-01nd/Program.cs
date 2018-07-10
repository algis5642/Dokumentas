using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_01nd
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("iveskite bendru draugu skaiciu:");
            var d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite Sauliaus draugu skaiciu:");
            var s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite Ramunes draugu skaiciu:");
            var r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite sutaupytu pinigu suma:");
            var g = Convert.ToInt32(Console.ReadLine());

            var f = (double)g / (s + d + r);
            Console.WriteLine("sutaupytu pinigeliu kiekis vienam sveciui " +f);


            Console.ReadKey();
        }
    }
}
