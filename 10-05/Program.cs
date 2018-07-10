using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prasome ivesti skaiciu ir uz ji didesni skaiciu:");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
           
            int i;
            if (pirmas<antras)
                for ( i= pirmas; i <= antras; i += 1)
                    Console.WriteLine(i +" "+ i*i  );
            else
                Console.WriteLine("negera salyga");
            Console.ReadKey();
        }
    }
}
