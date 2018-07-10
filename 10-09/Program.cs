using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_09
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;
            for (int i = 30; i < 50; i+=1)
            {
                if (i % 2 == 0)
                suma += i;

            }
            Console.WriteLine(suma);
            Console.ReadLine();



            Console.ReadKey();
        }
    }
}
