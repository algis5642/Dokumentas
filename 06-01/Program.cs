using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki, iveskite 3 skaicius");
            var a1 = Convert.ToInt32(Console.ReadLine());
            var a2 = Convert.ToInt32(Console.ReadLine());
            var a3 = Convert.ToInt32(Console.ReadLine());
            if ( a1>a2)
                Console.WriteLine(a1+ " didesnis nei " + a2);
            else if (a2 > a3)
                Console.WriteLine(a2+ " didesnis nei " + a3);
            else if (a3 > a1)
                Console.WriteLine(a3 + " didesnis nei " +a1);
            else if (a1 == a2)
                Console.WriteLine(a1 + " lygus " +a2);
    
            Console.ReadKey();
        }
    }
}
