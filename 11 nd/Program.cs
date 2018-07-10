using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_nd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kvadrato krastiniu ilgius:");
            var x = Convert.ToInt32(Console.ReadLine()); 
            var z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("plotas : {0} \n perimetras: {1}", x*z, 2*x+2*z);

            
            Console.ReadKey();
        }
    }
}
