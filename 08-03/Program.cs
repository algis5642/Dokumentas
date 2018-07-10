using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki, iveskite 3 egzaminu pazymius");
            var a1 = Convert.ToInt32(Console.ReadLine());
            var a2 = Convert.ToInt32(Console.ReadLine());
            var a3 = Convert.ToInt32(Console.ReadLine());
            var a4 = (double)(a1 + a2 + a3) / 3;
            Console.WriteLine("Vidurkis " + a4);
            if (a4 >= 8)
                Console.WriteLine("daugiau uz 8");
            
            else if (a4 >= 5)
                Console.WriteLine("tarp 5 ir 8");
            
            else
                Console.WriteLine("maziau nei 5");
        Console.ReadKey();
        }
    }
}
