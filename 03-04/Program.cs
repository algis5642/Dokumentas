using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = -1 + 4 * 6;
            var b = (35 + 5) % 7;
            var c = 14 + -4 * 6 / 11;
            var d = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine("{0} {1} {2} {3}" , a, b, c, d);
            Console.ReadKey();
        }
    }
}
