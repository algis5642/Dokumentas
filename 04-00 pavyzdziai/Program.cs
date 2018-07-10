using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_00_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jusu vardas :");
            var vardas = Console.ReadLine();
            Console.WriteLine("jusu pavarde:");
            var pavarde = Console.ReadLine();
            Console.WriteLine("ka vairuojate");
            var auto = Console.ReadLine();
            Console.WriteLine("megstamiausia spalva:");
            var spalva = Console.ReadLine();

            Console.WriteLine("jusu amzius?");
            var amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jusu ugis?");
            var ugis = Convert.ToInt32( Console.ReadLine());
            
            Console.WriteLine("gyvenamoji vieta?");
            var vieta = Console.ReadLine();

            Console.WriteLine("PIN KODAS?");
            var pin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gimimo data? metai/men/dien");
            var metai = Convert.ToInt32(Console.ReadLine());
            var menesis = Convert.ToInt32(Console.ReadLine());
            var diena = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("lytis? Vyr true, Mot False");
            var lytis = Convert.ToBoolean(Console.ReadLine());


            Console.WriteLine("Jusu suvesti duomenys:");
            Console.WriteLine(vardas);
            Console.WriteLine(pavarde);
            Console.WriteLine(auto);
            Console.WriteLine(spalva);
            Console.WriteLine(amzius);
            Console.WriteLine(ugis);
            Console.WriteLine(vieta);
            Console.WriteLine(pin);
            Console.WriteLine("amzius {0} {1} {2}", metai,menesis, diena);
            Console.ReadKey();
        }
    }
}
