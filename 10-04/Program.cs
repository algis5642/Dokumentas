using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            for (i = 0; i <= 10; i += 1)
            {   if (i % 2 == 0)
                Console.WriteLine("lyginis "+ i);
            }
            Console.ReadKey();
        }
    }
}
