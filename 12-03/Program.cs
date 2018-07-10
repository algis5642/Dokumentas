using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var sk = 0;
            var sk1 = 0;
            for (int i = 0; i <= 100; i++)
            {
                sk = sk + i * i;
                sk1 = sk1 + i;
            }
            Console.WriteLine(sk1*sk1 - sk);
            Console.ReadKey();
        }
    }
}
