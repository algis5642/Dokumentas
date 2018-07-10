using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki!!!!");
            Console.WriteLine("Suveskite savo varda, amziu ir hobi ");
            var vardas = Console.ReadLine();
            var amzius = Convert.ToInt32(Console.ReadLine());
            var hobis = Console.ReadLine();
            formatavimas(vardas, amzius, hobis);
            Console.ReadKey();
        }

            public static void formatavimas(string vardas, int amzius, string hobis)
        {
            Console.WriteLine("Jusu ivestas vardas : " + vardas);
            Console.WriteLine("Jusu ivestas amzius : " + amzius);
            Console.WriteLine("Jusu ivestas hobis : " + hobis);
        }


    }

    

    }

