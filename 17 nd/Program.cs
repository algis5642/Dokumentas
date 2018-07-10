using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_nd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite 2 skaicius:");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("vidurkis " + (a+b)/2);

            Console.ReadKey();
        }
    }
}
