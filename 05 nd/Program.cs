using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_nd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ivesk skaiciu:");
            var x = Convert.ToInt32( Console.ReadLine());
            if (x%2 == 0)
            { Console.WriteLine("lyginis skaicius");}
                    else
                    Console.WriteLine("nelyginis");
            Console.ReadKey();
        }
    }
}
