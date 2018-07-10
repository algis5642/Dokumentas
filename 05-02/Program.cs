using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prasom iveskite savo amziu:");
            var amzius = Convert.ToInt32(Console.ReadLine());
            if (amzius >= 18)
                Console.WriteLine("Jus galite balsuoti");
                    if (amzius < 18)
                Console.WriteLine("Jus negalite balsuoti");
            Console.ReadKey();
        }
    }
}
