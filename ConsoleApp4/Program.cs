using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = 3;
            var d = 0;
            
            Console.WriteLine("{0} * {1} = {2}" , s, d,s*d++);
            Console.WriteLine("{0} * {1} = {2}", s, d, s * d++);
            Console.WriteLine("{0} * {1} = {2}", s, d, s * d++);
            Console.WriteLine("{0} * {1} = {2}", s, d, s * d++);
            Console.WriteLine("{0} * {1} = {2}", s, d, s * d++);
            Console.WriteLine("{0} * {1} = {2}", s, d, s * d++);
            Console.WriteLine("{0} * {1} = {2}", s, d, s * d++);
            Console.WriteLine("{0} * {1} = {2}", s, d, s * d++);
            Console.WriteLine("{0} * {1} = {2}", s, d, s * d++);
            Console.WriteLine("{0} * {1} = {2}", s, d, s * d++);
            Console.WriteLine("{0} * {1} = {2}", s, d, s * d++);



            Console.ReadKey();
        }
    }
}
