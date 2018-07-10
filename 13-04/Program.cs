using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temperaturos = { 20, 25, 22, 26, 21, 19, 25 };
            var min = temperaturos[0];
            var max = temperaturos[0];
            var aver = temperaturos[0];
            var suma = 0;
            var karsta = 0;
            var salta = 0;



            foreach (var skaic in temperaturos)
            {
                if (skaic < min)
                {
                    min = skaic;
                }
            }

            foreach (var skaic2 in temperaturos)
            {
                if (skaic2 > max)
                {
                    max = skaic2;
                }

            }

            foreach (var skaic3 in temperaturos)
            {
                suma = suma + skaic3;
            }

            Console.WriteLine(min);
            Console.WriteLine(max);
            aver = suma / temperaturos.Length;
            Console.WriteLine(aver);
            foreach (var skaic4 in temperaturos)
            {
                if (aver > skaic4)
                {
                    karsta += 1;
                }
                else if (aver < skaic4)

                {
                    salta++;
                }

            }
            Console.WriteLine("Siltesniu dienu nei vid skaicius " +karsta);
            Console.WriteLine("vesesniu dienu nei vid skaicius " +salta);
            Console.ReadKey();

        }
    


            
        }
    }

