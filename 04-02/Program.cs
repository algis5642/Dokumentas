using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki, atspausdinkite simboli:");
            var s = Convert.ToChar(Console.Read());
            Console.WriteLine("{0}{0}{0}\n{0}{0}{0}\n{0}{0}{0}", s);
            Console.ReadKey();
        }
    }
}
