using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakas = 50;
            int[] nuvaziuotiKM = { 920, 999, 850, 698, 985, 877, 987, 856, 778, 855, 987 };
            int min = nuvaziuotiKM[0];
            int max = nuvaziuotiKM[0];
            int sum = 0;
            foreach (int km in nuvaziuotiKM)
            {
                if (km < min)
                { min = km; }

            }

            foreach (int km in nuvaziuotiKM)
            {
                if (km > max)
                {
                    max = km;
                }
            }
            foreach (int km in nuvaziuotiKM)
            {
                sum = sum + km;
            }

            Console.WriteLine("min " + min);
            Console.WriteLine("max " + max);
            Console.WriteLine("vid sanaud. " + bakas*(double)100/((sum/nuvaziuotiKM.Length)));
            
            Console.ReadKey();
        }
    }
}
