using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prasome ivesti skaiciu ir uz ji didesni skaiciu:");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());

            int i;
            int daug = 0;
                

                for (i = 0; i < antras; i += 1)
                    daug = daug + pirmas;
                         
            Console.WriteLine("daugyba = "+ daug);
            Console.ReadKey();
        }
    }
}
