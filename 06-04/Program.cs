using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite gauta pazimy:");
            var paz = Convert.ToInt32(Console.ReadLine());
            if (paz ==10)
                Console.WriteLine("Puikiai");
            else if (paz >=8)
                Console.WriteLine("Labai gerai");
            else if (paz >= 7)
                Console.WriteLine("patenkinamai");
            else if (paz >=3)
                Console.WriteLine("Prastai");
            else if (paz >=1)
                Console.WriteLine("Labai blogai!");
            Console.ReadKey();
        }
    }
}
