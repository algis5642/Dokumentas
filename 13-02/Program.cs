using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 0;
            Console.WriteLine("iveskite masyvo ilgi:");
            var mas = Convert.ToInt32(Console.ReadLine());
            int[] masyvas = new int[mas];
            for (int i = 0; i<mas; i++)
            {
                masyvas[i] = x + i;
            }
            foreach (var skaic in masyvas)
            {
                Console.Write(skaic+ " ");
            }
           // Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
