using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int pasirinkimas;

            do
            {
                Console.WriteLine("suo -1 , kate -2 , papuga -3");
                pasirinkimas = Convert.ToInt32(Console.ReadLine());
                if (pasirinkimas < 1 || pasirinkimas > 3)
                {
                    Console.WriteLine("blogai ivestas skaicius ");
                }
            }
            while (pasirinkimas < 1 || pasirinkimas > 3);
                Console.WriteLine("pasirinkimas: " + pasirinkimas);

            

        }
    }
}
