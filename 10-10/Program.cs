using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;
            for (int i = 30; i < 60; i += 1)
            {
                if (i % 2 > 0)
                suma += i;

            }
            Console.WriteLine(suma);
           
            Console.ReadKey();
        }
    }
}
