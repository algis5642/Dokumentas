using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prasome ivesti 5 pazymius:");
            var a1 = Convert.ToInt32(Console.ReadLine());
            var a2 = Convert.ToInt32(Console.ReadLine());
            var a3 = Convert.ToInt32(Console.ReadLine());
            var a4 = Convert.ToInt32(Console.ReadLine());
            var a5 = Convert.ToInt32(Console.ReadLine());
            var vid = Convert.ToDouble(a1 + a2 + a3 + a4 + a5) / 5;
            Console.WriteLine("Jusu vidurkis yra {0}", vid ) ;
            if (vid >= 5)
                Console.WriteLine("Sveikiname, jusu vidurkis patenkinamas");

            Console.ReadKey();
        }
    }
}
