using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seka = new int[10];
            int a = 1;
            int b = 0;
            int z = 0;
            for (int i = 0; i <10; i++)
            {
                z = a + b;
                a = b;
                b = z;
                seka[i] = z;
                Console.WriteLine(seka[i]);
            }
            Console.ReadKey();
        }
    }
}
