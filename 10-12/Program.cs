using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for (int i =0; i<=100; i +=1)
            {
                if ((suma + i) % 5 == 0 && (suma + i) % 3 == 0)

                    Console.WriteLine("Fizz");
                else if ((suma + i) % 5 == 0)
                    Console.WriteLine("Buzz");
                else if ((suma + i) % 3 == 0)
                    Console.WriteLine("FizzBuzz");
                else
                    Console.WriteLine(suma+i);

              
            }
                Console.ReadKey();
        }  
    }
}
