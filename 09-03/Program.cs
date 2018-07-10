using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki, irasykite pasirinkimo skaiciu:");
            Console.WriteLine("kava: 1");
            Console.WriteLine("arbata: 2");
            Console.WriteLine("karstas vanduo: 3");
            var pas = Convert.ToInt32(Console.ReadLine());

            switch (pas)
            {
                case 1:
                    Console.WriteLine("jus pasirinkote Kava");
                    break;
                case 2:
                    Console.WriteLine("jus pasirinkote arbata");
                    break;
                case 3:
                    Console.WriteLine("Jus pasirinkote karsta vandeni");
                    break;
                default:
                Console.WriteLine("tokio pasirinkimo nera");
                    break;
            }
                Console.ReadKey();
        }
    }
}
