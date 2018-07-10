using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki, iveskite 3 sveikuosius skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            if (a == b)
                Console.WriteLine("Pirmas ir antras skaiciai lygus");
            if (b == c)
                Console.WriteLine("antras ir trecias skaiciai lygus");
            if (a>b)
                Console.WriteLine("Pirmas skaicius didesnis uz antraji");
            if (b> 2*c)
                Console.WriteLine("antras skaicius daugiau nei dvigubai didesnis uz treciaji");
            if ( a % 2 == 0)
                Console.WriteLine(a+ " yra lyginis skaicius");
            if ( b % 2 ==0 )
                Console.WriteLine(b+ " yra lyginis");
            if (c > 0)
                Console.WriteLine(c + " teigiamas");
            if (c < 0)
                Console.WriteLine(c+ " yra neigiamas");

            Console.ReadKey();
        }
    }
}
