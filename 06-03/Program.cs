using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki, kokia siandien temperatura ?");
            var tem = Convert.ToInt32(Console.ReadLine());
            if (tem <0)
                Console.WriteLine("ziauriai salta");
            else if (tem < 10)
                Console.WriteLine("labai salta");
            else if (tem < 20)
                Console.WriteLine("salta");
            else if (tem < 30)
                Console.WriteLine("normali temperatura");
            else if (tem < 40)
                Console.WriteLine("karsta");
            else if (tem >40)
                Console.WriteLine("ziauriai degina");

            Console.ReadKey();
        }
    }
}
