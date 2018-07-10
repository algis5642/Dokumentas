using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pazymiuSarasas = new List<int>();
            Console.WriteLine("prasome pasirinkti kiek norite suvesti studentu pazymiu:");
            var pazskai = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <pazskai; i++)
            {
                int r = 1 + i;
                Console.WriteLine("suveskite pazymi nr. : {0}", r);
                var pazymys = Convert.ToInt32(Console.ReadLine());
                pazymiuSarasas.Add(pazymys);
            }

            Console.WriteLine("Didziausias pazymys " + pazymiuSarasas.Max());
            Console.WriteLine("Maziausias pazymys " + pazymiuSarasas.Min());
            Console.WriteLine("Vidurkis " + pazymiuSarasas.Average());
            var Randpaz = new Random();
            var random1 = Randpaz.Next(pazymiuSarasas.Count);

            Console.WriteLine("New Random: " + pazymiuSarasas[random1] );


            Console.ReadKey();
        }
    }
}
