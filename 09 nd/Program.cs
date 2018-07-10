using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_nd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sveiki, iveskite greiti km/h:");
            var kil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("mylios/h " + (kil*0.621));
            Console.ReadKey();
        }
    }
}
