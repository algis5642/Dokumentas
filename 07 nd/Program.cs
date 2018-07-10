using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_nd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite varda:");
            var vard = Console.ReadLine();
            string Petras;
            switch (vard)
            {
                case "Petras":
                Console.WriteLine("Labas Petrai!");
                break;

                default:
                Console.WriteLine("nelabas");
                break;
            }
               Console.ReadKey();   
        }  

               
            
        }
}

