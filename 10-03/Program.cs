using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            for (i=0; i<=20 ; i += 3)
            {
                Console.Write("[{0}] ", i);
            }
            
            Console.ReadKey();
        }
    }
}
