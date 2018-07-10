using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_nd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            var n = Convert.ToInt32(Console.ReadLine());
            int z = 0;
            for (int i = 0; i < n; i +=1 )
            {
                Console.WriteLine(i+1);
            }
            Console.ReadKey();
        }
    }
}
