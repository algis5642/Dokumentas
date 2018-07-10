using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            
            var atsi2 = rand.Next(50);
            List<int> sarasiukas = new List<int>();
            var sum = 0;



            for (int i = 0; i < atsi2; i++)
            {
                var atsi1 = rand.Next(100);
                sarasiukas.Add(atsi1);

            }

  

            
            
            

            var aver = 0;

            foreach (int skaicius in sarasiukas)
            {
                if (sarasiukas.Average()> skaicius )
                {
                    aver = aver + 1;
                }
            }

            var lyginiai = 0;

            foreach (int skaicius in sarasiukas)
            {
                if (skaicius % 2 == 0 )
                {
                    lyginiai++;
                }
            }

            Console.WriteLine("min" + sarasiukas.Min());
            Console.WriteLine("max" + sarasiukas.Max());
            Console.WriteLine("average" + sarasiukas.Average());
            Console.WriteLine("mazesni uz vid " + aver);
            Console.WriteLine("lyginiai "+ lyginiai);
            foreach (int skaicius in sarasiukas)
                Console.WriteLine(skaicius);
            Console.ReadKey();


        }
    }
}
