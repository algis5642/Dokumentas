using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nd03_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomai = new Random();
            //var atsk = randomai.Next(15);
            //var atsk1 = randomai.Next(6);
            List<int> prekesParduotuveje = new List<int>();
            List<int> prekesAtveztos = new List<int>();
            List<int> prekiuSuma = new List<int>();

            for (int i = 0; i< 100; i++)
            {
                var atsk = randomai.Next(15);
                prekesParduotuveje.Add(atsk);
                var atsk1 = randomai.Next(6);
                prekesAtveztos.Add(atsk1);
                
            }

            for (int i = 0; i< 100; i++)
            {
                prekiuSuma.Add(prekesParduotuveje[i] + prekesAtveztos[i]);
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("{0} + {1} = {2}", prekesParduotuveje[i], prekesAtveztos[i] , prekiuSuma[i] );
            }
            Console.ReadKey();
            
        }
    }
}
