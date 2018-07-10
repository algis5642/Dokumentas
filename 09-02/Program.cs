using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki, iveskite gyvuno rusi:");
            var gyvunas = Console.ReadLine();
            switch (gyvunas)
            { case "kate":
                    Console.WriteLine("kate");
                    break;
                case "suo":
                    Console.WriteLine("suo");
                    break;
                case "ziurkenas":
                    Console.WriteLine("ziurkenas");
                    break;
                case "triusis":
                    Console.WriteLine("triusis!");
                    break;

                case "papuga":
                    Console.WriteLine("papuga!!!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
