using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki, iveskite skaiciu");
            var sk = Convert.ToInt32(Console.ReadLine());
            var d = 0;
            Console.WriteLine("{0}*{1}={2}", sk, d, sk*d++);
            Console.WriteLine("{0}*{1}={2}", sk, d, sk * d++);
            Console.WriteLine("{0}*{1}={2}", sk, d, sk * d++);
            Console.WriteLine("{0}*{1}={2}", sk, d, sk * d++);
            Console.WriteLine("{0}*{1}={2}", sk, d, sk * d++);
            Console.WriteLine("{0}*{1}={2}", sk, d, sk * d++);
            Console.WriteLine("{0}*{1}={2}", sk, d, sk * d++);
            Console.WriteLine("{0}*{1}={2}", sk, d, sk * d++);
            Console.WriteLine("{0}*{1}={2}", sk, d, sk * d++);
            Console.WriteLine("{0}*{1}={2}", sk, d, sk * d++);
            Console.WriteLine("{0}*{1}={2}", sk, d, sk * d++);
            Console.ReadKey();
        }
    }
}
