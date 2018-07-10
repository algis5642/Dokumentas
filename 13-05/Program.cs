using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pazymiai = { 8, 4, 9, 6, 5, 4, 8, 5, 8, 5, 9, 2, 5, 7, 1, 6, 5, 8, 9, 7, 10, 4 };
            int max = pazymiai[0];
            int desimtukin = 0;
            int neigiami = 0;

            foreach (int ska in pazymiai)
            {
                if (ska > max)
                {
                    max = ska;
                }

            }

            foreach (int ska in pazymiai)
            {
                if (ska == 10)
                {
                    desimtukin++;
                }
            }

            foreach (int ska in pazymiai)
            {
                if (ska < 4)
                {
                    neigiami++;
                }
            }

            Console.WriteLine("max " + max);
            Console.WriteLine("desimt " +desimtukin);
            Console.WriteLine("neigiami " +neigiami);

            Console.ReadKey();
        }
    }
}
