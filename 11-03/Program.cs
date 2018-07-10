using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var pasirinkimas = "t";
            

            while (pasirinkimas == "t")
            {
                Console.WriteLine("iveskite 2 skaicius:");
                var x = Convert.ToDouble(Console.ReadLine());
                var z = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("{0} + {1} = {2}", x, z, x+z);
                Console.WriteLine("{0} - {1} = {2}", x, z, x - z);
                Console.WriteLine("{0} * {1} = {2}", x, z, x * z);
                Console.WriteLine("{0} / {1} = {2}", x, z, x / z);
                Console.WriteLine("testi darba? t/n");
                pasirinkimas = Console.ReadLine();



            }

        }
    }
}
