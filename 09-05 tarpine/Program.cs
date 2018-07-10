using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_05_tarpine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kepalu skaiciavimo programa");
            Console.WriteLine("Prasome ivesti kiek darbuotojas iskepa kepalu per valanda:");
            var darbuotojoNasumas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite darbuotoju skaiciu");
            var darbuotojuskaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite vieno kepalo savikaina:");
            var savikaina = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kepalo pardavimo kaina:");
            var kaina = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite uzsakytu kepalu skaiciu siai dienai:");
            var uzsakymas = Convert.ToInt32(Console.ReadLine());
            var darbolaikas = 8;
            var iskepta = darbolaikas * darbuotojuskaicius * darbuotojoNasumas;
            var savi = iskepta * savikaina;
            var plan = iskepta * kaina;
            var peln = plan - savi;
            var realplan = uzsakymas * kaina;
            var realpeln = realplan - savi;


            Console.WriteLine("Per diena bus iskepta {0} duonos kepalu", iskepta);

            if (iskepta < uzsakymas)
            Console.WriteLine("Duonos kepalu savikaina bus {0}\n Planuojamos pajamos {1} \n Planuojamas pelnas {2}", savi, plan, peln);
            else
                Console.WriteLine("Duonos kepalu savikaina bus {0}\n Planuojamos pajamos {1} \n Planuojamas pelnas {2}", savi, realplan, realpeln);
            if (iskepta<uzsakymas)
                Console.WriteLine("kepykla nespes iskepti {0} kepalu duonos", uzsakymas-iskepta);
            else
                Console.WriteLine("kepykla ispildys uzsakyma pilnai");


            
            Console.ReadKey();
        }
    }
}
