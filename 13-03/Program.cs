using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("iveskite masyvo ilgi:");
            //var mas = Convert.ToInt32(Console.ReadLine());
            
            int[] masyvas = { 5, 6, 7, 7, 2, 9, 4, 8 };
            var x = masyvas[0];
            for (int i = 0; i < masyvas.Length ; i++)
            {
                if (masyvas[i]>x)
                x= masyvas[i];
            }
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
