using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki, iveskite skaiciu:");
            var sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skaiciaus {0} kvadratas : {1}", sk, Math.Pow(sk,2));
            Console.ReadKey();
        }
    }
}
