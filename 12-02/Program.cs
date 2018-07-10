using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius = 0;
            do
            {
                skaicius = skaicius + 1;

            }
            while (!(skaicius % 1 == 0 && skaicius % 2 == 0 && skaicius % 3 == 0 && skaicius % 4 == 0 && skaicius % 5 == 0 && skaicius % 6 == 0 && skaicius % 7 == 0 && skaicius % 8 == 0 && skaicius % 9 == 0 && skaicius % 10 == 0 && skaicius % 11 == 0 && skaicius % 12 == 0 && skaicius % 13 == 0 && skaicius % 14 == 0 && skaicius % 15 == 0 && skaicius % 16 == 0 && skaicius % 17 == 0 && skaicius % 18 == 0 && skaicius % 19 == 0 && skaicius % 20 == 0));
            Console.WriteLine(skaicius);
            Console.ReadKey();
        }
    }
}
