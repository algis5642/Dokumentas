using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prasome ivesti betkoki neigiama skaiciu :");
            var sk = Convert.ToInt32(Console.ReadLine());
            if (sk < 0)
                Console.WriteLine("Ka tu padarei !!!");
            if (sk >= 0)
                Console.WriteLine("Saunuolis");
            if (sk % 2 == 0)
                Console.WriteLine("skaicius yra lyginis");
            if (sk % 4 == 0)
                Console.WriteLine("skaicius dalinasi is keturiu");
                    if (sk > 10)
                Console.WriteLine("skaicius didesnis nei 10");

            Console.ReadKey();
        }
    }
}
