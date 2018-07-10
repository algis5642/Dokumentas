using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_06
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Prasome ivesti skaiciu ir uz ji didesni skaiciu:");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());

            int i;
            if (pirmas < antras)
            {

                for (i = pirmas; i <= antras; i += 1)
                    if (i % 2 != 0 || i % 8 == 0)
                    {
                        Console.WriteLine(i);
                    }
            }
            else


                Console.WriteLine("negera salyga");
            

            Console.ReadKey();
        }
    }
}
