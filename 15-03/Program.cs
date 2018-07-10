using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine("Sveiki, iveskite du skaicius");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            var sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sudetis = " +p.sudetis(sk1, sk2));
            Console.WriteLine("atimtis = " +p.atimtis(sk1, sk2));
            Console.WriteLine("daugyba = " +p.daugyba(sk1, sk2));
            Console.WriteLine("dalyba = " + p.dalyba(sk1 , sk2));
            Console.ReadKey();
        }
        private int sudetis(int a, int b)
        {
            return a + b;
            
        }
        private int atimtis(int a, int b)
        {
            return a - b;

        }
        private int daugyba(int a, int b)
        {
            return a * b;
        }
        private int dalyba(int a, int b)
        {
            return a / b;
        }

    }
}
