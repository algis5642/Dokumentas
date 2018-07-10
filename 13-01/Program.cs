using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pazymiai= { 8, 9, 10 };
            string[] masinu_markes = { "VW", "Audi", "Aston" };
            char[] raides = { 'a', 'b', 'c' };
            Console.WriteLine(pazymiai.Length);
            Console.WriteLine("pirmas paz" +pazymiai[0]);
            Console.WriteLine("paskut. reiksm:" +pazymiai[pazymiai.Length-1]);

            Console.ReadKey();
        }
    }
}
