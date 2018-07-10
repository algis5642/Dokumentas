using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki, iveskite 2 skaicius:");
            var a1 = Convert.ToInt32(Console.ReadLine());
            var a2 = Convert.ToInt32(Console.ReadLine());
            if (a1 > a2)
                Console.WriteLine(a1+ " didesnis uz " +a2);
            else if (a2> a1)
                Console.WriteLine(a2+ " didesnis uz " +a1);
            else
                Console.WriteLine("abu skaiciai lygus");

            Console.ReadKey();
        }
    }
}
