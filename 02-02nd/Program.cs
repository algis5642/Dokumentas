using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_02nd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite v1:");
            var v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite m1:");
            var m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite m2:");
            var m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite v:");
            var v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite m:");
            var m = Convert.ToInt32(Console.ReadLine());

            var f = (v1*60)+m1+m2;
            var f1 = (v * 60) + m;
            if (f>f1)
                Console.WriteLine("Paveluos");
            else
                Console.WriteLine("Suspes");
            Console.ReadKey();

            
        }
    }
}
