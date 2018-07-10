using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sveiki, iveskite 2 skaicius");
            var a1 = Convert.ToInt32(Console.ReadLine());
            var a2 = Convert.ToInt32(Console.ReadLine());
    if (a1 > a2 || a1 == 0)
                Console.WriteLine(a1 + " didesnis arba lygus 0" );
    if (a2 > a1 || a2==5 )
                Console.WriteLine(a2 + " didesnis uz {0} arba lygus 5", a1);
    if ( a1> a2 && a1 == 20)
                Console.WriteLine(a1 + " didesnis uz {0} ir lygus 20", a2);
    if  (a2> a1 && a2<100)
                Console.WriteLine(a2 + " didesnis uz {0} ir mazesnis uz 100" , a1);
            Console.ReadKey();
        }
    }
}
