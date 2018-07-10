using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        { var marke = "VW";
            var modelis = "Golf";
            var metai = 2006;
            var rida = 300000;
            
            Console.WriteLine("***********");
            Console.WriteLine("*         *");
            Console.WriteLine("*         *");
            Console.WriteLine("*         *");
            Console.WriteLine("*         *");
            Console.WriteLine("***********");
            Console.WriteLine("Automobilio markė {0} modelis {1} metai (m.) {2} rida - {3} km.", marke, modelis, metai, rida);
            Console.ReadKey();
        }
    }
}
