using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("t1");
            var t1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("k");
            var k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("t");
            var t = Convert.ToInt32(Console.ReadLine());
            var i = 0;
            var c = 0;


            while (t > 0)
            {
                t = t - (t1 + (k * i++));

                if (t > 0)
                {
                    c = i;
                }
                //Console.WriteLine(i++);
            }
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
