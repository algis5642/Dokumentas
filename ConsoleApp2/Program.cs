using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        { var vardas = "Algirdas";
            var amzius = 28;
            var skaicius = 10;
            Console.WriteLine("Labas " + vardas);
            Console.WriteLine("ivestas amzius: {0}", amzius );
            Console.WriteLine("{0}{0}{0}{0}{0}", skaicius);
            Console.WriteLine("{0} {0} {0} {0} {0}", skaicius);

            
            Console.ReadKey();
        }
    }
}
