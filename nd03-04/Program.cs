using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nd03_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomai = new Random();
            List<int> masyvas1 = new List<int>();
            List<int> masyvas2 = new List<int>();
            var max = 0;

            for (int i = 0; i < 10; i++)
            {
                var atsk = randomai.Next(5);
                masyvas1.Add(atsk);
                var atsk1 = randomai.Next(5);
                masyvas2.Add(atsk1);
                Console.ReadKey();
            }
            if (masyvas1.Max() > masyvas2.Max())
            {
                max = masyvas1.Max();
            }
            else
                max = masyvas2.Max();
                
               Console.WriteLine("Didziausias masyvo skaicius  " + max);

            /* foreach (int skaicius in masyvas1)
            {
                if (skaicius == max)
                    masyvas1.Remove(max);
                
            }
            foreach (int skaicius in masyvas2)
            {
                if (skaicius == max)
                    masyvas2.Remove(max);
            }
            */
            foreach (int skaiciai in masyvas1)
            {
                Console.WriteLine(" masyvas 1 : " +skaiciai);
            }

            foreach (int skaiciai in masyvas2)
            {
                Console.WriteLine(" masyvas 2 : " + skaiciai);
            }
            Console.ReadKey();






        }
    }
}
