using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_05
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 0;
            while ( x != 9 )
            {
                Console.Write("iveskite skaiciu ");
                x = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("ivedete skaiciu 9! ");
            Console.ReadKey();
        }
    }
}
