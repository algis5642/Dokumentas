using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("prasome ivesti 3 skaicius");
            var pir = Convert.ToDouble(Console.ReadLine());
            var ant = Convert.ToDouble(Console.ReadLine());
            var tre = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Skaiciu {0} {1} {2} vidurkis {3}", pir, ant, tre, (pir+ant+tre)/3);
            Console.ReadKey();
        }
    }
}
