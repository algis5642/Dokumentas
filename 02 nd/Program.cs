using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_nd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki, iveskite varda, pavarde ir gimimo metus:");
            var vardas = Console.ReadLine();
            var pavarde = Console.ReadLine();
            var metai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(vardas + " " +pavarde+ " " + metai);
            Console.ReadKey();
        }
    }
}
