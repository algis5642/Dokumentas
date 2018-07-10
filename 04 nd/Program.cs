using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_nd
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToDouble(Console.ReadLine());
           
            var ab = (a*a);
            var ac = (a*a*a);
            
            Console.WriteLine(ab+ " " + ac);

            Console.ReadKey();
        }
    }
}
