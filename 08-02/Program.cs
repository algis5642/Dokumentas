using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki, iveskite 3 skaicius");
            var a1 = Convert.ToInt32(Console.ReadLine());
            var a2 = Convert.ToInt32(Console.ReadLine());
            var a3 = Convert.ToInt32(Console.ReadLine());
            if (a1 < a2 && a1 < a3)
                Console.WriteLine(a1 + " maziausias");
            else if (a2 < a1 && a2 < a3)
                Console.WriteLine(a2 + " maziausias");
            else
                Console.WriteLine(a3 + " maziausias");
            Console.ReadKey();
        }
    }
}
