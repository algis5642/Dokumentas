using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_0_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardas = "ALGIRDAS";
            var pavarde = "Skr";
            var amzius = 28;

            Console.WriteLine("Labas");
            Console.WriteLine("krabas");

            Console.WriteLine(vardas);
            Console.WriteLine(pavarde);
            Console.WriteLine(amzius);

            Console.WriteLine("vardas: " + vardas);
            Console.WriteLine("pavarde: " + pavarde);
            Console.WriteLine("amzius: " + amzius);

            Console.WriteLine("vardas: {0}"  , vardas);
            Console.WriteLine("pavarde: {0}" , pavarde);
            Console.WriteLine("amzius: {0}" , amzius);

            Console.WriteLine("vardas ir pavarde: " +vardas +" " +pavarde);
            Console.WriteLine("vardas ir pavarde: {0} {1}", vardas, pavarde);

            Console.WriteLine(vardas + " " + pavarde + " (" + amzius + "m.)");
            Console.WriteLine("{0} {1} ({2}m.)",vardas ,pavarde ,amzius);
        }
    }
}
