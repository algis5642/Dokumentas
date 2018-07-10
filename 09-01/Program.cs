using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius ;)");
            var a1 = Convert.ToInt32(Console.ReadLine());
            var a2 = Convert.ToInt32(Console.ReadLine());
            var a3 = Convert.ToInt32(Console.ReadLine());
            switch (a1)
            {
                case 1:
                    Console.WriteLine(a1 + a2 + a3);
                    break;
                case 2:
                    Console.WriteLine(a1 - a3);
                    break;
                case 3:
                    Console.WriteLine(a2 * a3);
                    break;
            }

                
           

            Console.ReadKey();
        }
    }
}
