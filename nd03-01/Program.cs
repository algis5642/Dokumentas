using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nd03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prasome suvesti apskritimo spindulius:");
            List<int> spinduliai = new List<int>();
            bool tesimas = true;
            int n = 0;

            do
            {
                n =n+ 1;

                Console.WriteLine("Iveskite apskritimo {0} spinduli:", n);
                int spindulys = Convert.ToInt32(Console.ReadLine());
                spinduliai.Add(spindulys);
                Console.WriteLine("testi? t/n?");
                var x = Console.ReadLine();
                if (x != "t")
                {
                    tesimas = false;
                }
            } while (tesimas);

               Console.WriteLine("didziausias spindulys: "+ spinduliai.Max());
                int max = spinduliai.Max();
                int maxCount = 0;
               foreach (int skaiciai in spinduliai)
                
            {
                if (max == skaiciai)
                {
                    maxCount += 1;
                }

            }
                    Console.ReadKey();
            Console.WriteLine("didziausiu spinduliu skaicius: " +maxCount);
            Console.ReadKey();

            }
        }
    }

