using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_nd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stataus trikampio krastiniu ilgius:");
            var x = Convert.ToInt32(Console.ReadLine());
            var z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("plotas : {0} \n perimetras: {1}", (x * z)/2, (x+z)+ Math.Sqrt(x*x+z*z));
            
            Console.ReadKey();
        }
    }
}
