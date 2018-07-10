using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardas = "Bevardis";
            var pavarde = "Bepavardis";
            var amzius = 100;
            Console.WriteLine(vardas);
            Console.WriteLine(pavarde);
            Console.WriteLine(amzius);
            pakeitimas(ref vardas,ref pavarde,ref amzius);
            Console.WriteLine(vardas);
            Console.WriteLine(pavarde);
            Console.WriteLine(amzius);
            Console.ReadLine();


        }
        private static void pakeitimas(ref string vardas, ref string pavarde,ref int amzius)
        {
            Console.WriteLine("vardas:");
            vardas = Console.ReadLine();
            Console.WriteLine("pavarde:");
            pavarde = Console.ReadLine();
            Console.WriteLine("amzius:");
            amzius = Convert.ToInt32(Console.ReadLine());
            
        }



    }
}
