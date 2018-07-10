using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki. Pasirinkite megstamiausia elektronini prietaisa is saraso:");
            Console.WriteLine("Stacionarus PC: 1");
            Console.WriteLine("Laptopas: 2");
            Console.WriteLine("Plansete: 3");
            Console.WriteLine("Smartphonas: 4");
            var pasirinkimas = Convert.ToInt32(Console.ReadLine());
            switch (pasirinkimas)
            {
                case 1:
                    Console.WriteLine("Pc gerai namams");
                    break;
                case 2:
                    Console.WriteLine("Laptopas gerai darbui");
                    break;
                case 3:
                    Console.WriteLine("Plansete gerai pramogoms");
                    break;
                default:
                    Console.WriteLine("tokio pasirinkimo NERA!!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
