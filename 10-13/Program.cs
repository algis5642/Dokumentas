using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int z = 0;
            int s = 0;
            for (int i=2; i<100; i++)
            {
                s = x + z;
                x = z;
                z = s;


               // Console.WriteLine(x);
               // Console.WriteLine(z);

                Console.WriteLine(s);
            }
            
            Console.ReadKey();
        }
    }
}
