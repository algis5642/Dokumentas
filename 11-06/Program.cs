using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_06
{
    class Program
    {
        static void Main(string[] args)
        {
            var atsitiktinisObj = new Random();
            var skai1 = atsitiktinisObj.Next(1, 10);
            Console.WriteLine("Atspekite skaiciu nuo 1 iki 10");
            var zaidimas = " ";
            int x;
            while (zaidimas != "pergale")
            {
                
                
                Console.WriteLine("spekite skaiciu:");
                x = Convert.ToInt32(Console.ReadLine());
                if (skai1 > x)
                {
                    Console.WriteLine("Slaptas skaicius didesnis");
                }

                else if (skai1 < x)
                { Console.WriteLine("Slaptas skaicius mazesnis"); 
                }
                if (skai1 == x)
                {
                    zaidimas = "pergale";
                    Console.WriteLine("Pergale!!!");
                }

            }

            Console.ReadKey();
        }
    }
}
