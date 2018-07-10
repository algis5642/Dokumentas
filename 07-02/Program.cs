using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite norima skaiciu");
            var a1 = Convert.ToInt32(Console.ReadLine());
            if (a1 > 0)
                Console.WriteLine(a1+ " teigiamas");
            else if (a1<0)
                Console.WriteLine(a1+ " neigiamas");
            else
                Console.WriteLine("skaicius lygus nuliui");
            Console.ReadKey();
        }
    }
}
