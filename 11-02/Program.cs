using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite neigiama skaiciu:");
            var x = Convert.ToInt32(Console.ReadLine());
            while (x <= 0)
            {
                Console.Write(x+" ");
                x++;

            }
            Console.ReadKey();
        }
    }
}
