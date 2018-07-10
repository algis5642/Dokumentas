using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> zodziai = new List<string>();
            List<int> raidsk = new List<int>();
            zodziai.Add("labas");
            zodziai.Add("rytas");
            zodziai.Add("kaip");
            zodziai.Add("sekasi");
            zodziai.Add("jums");
            zodziai.Add("siandien");
            string trumpiausias = "aa";
            int a = 0;
            string ilgiausias = "bb";
            int b = 0;

            Console.WriteLine("ilgiausias zodis: ");

            foreach (string zodis in zodziai)
            {
                raidsk.Add(zodis.Length);
                if (zodis.Length < zodziai[0].Length)
                {
                    trumpiausias = zodis;
                    a = zodis.Length;
                }
                
            }

            foreach (string zodis in zodziai)
            {
                raidsk.Add(zodis.Length);
                if (zodis.Length > zodziai[0].Length)
                {
                    ilgiausias = zodis;
                    b = zodis.Length;
                }

            }

            Console.WriteLine(" ilgiausias zodis : {0} ir {1} raidziu.", ilgiausias, b);
            Console.WriteLine(" trumpiausias zodis : {0} ir {1} raidziu " , trumpiausias, a);




            Console.ReadKey();
        }
    }
}
