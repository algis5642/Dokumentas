using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_05
{
    class Program
    {
        static void Main(string[] args)
        {
            bool testi = true;
            do
            {
                Console.WriteLine("Pasirinkite programa kuria noretumete paleisti :");
                int pas;
                do
                {
                    Console.WriteLine("1 - sarasiukas ");
                    Console.WriteLine("2 - randomas");
                    pas = Convert.ToInt32(Console.ReadLine());
                    if (pas < 1 || pas > 2)
                    {
                        Console.WriteLine("pasirinkimas turi buti 1 arba 2");
                    }
                }
                while (pas < 1 || pas > 2);



                switch (pas)
                {
                    case 1:
                        sarasiukas();
                        break;
                    case 2:
                        Randomas();
                        break;
                }


                
                Console.WriteLine("testi ? t/n");
                var tes = Console.ReadLine();
                if (tes != "t")
                {
                    testi = false;
                }
            }

            while (testi);

            
            
            }

        static public void sarasiukas()
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
                    if (sarasiukas.Average() > skaicius)
                    {
                        aver = aver + 1;
                    }
                }

                var lyginiai = 0;

                foreach (int skaicius in sarasiukas)
                {
                    if (skaicius % 2 == 0)
                    {
                        lyginiai++;
                    }
                }

                Console.WriteLine("min" + sarasiukas.Min());
                Console.WriteLine("max" + sarasiukas.Max());
                Console.WriteLine("average" + sarasiukas.Average());
                Console.WriteLine("mazesni uz vid " + aver);
                Console.WriteLine("lyginiai " + lyginiai);
                foreach (int skaicius in sarasiukas)
                    Console.WriteLine(skaicius);
                Console.ReadKey();


            }




            public static void Randomas()
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
                    if (sarasiukas.Average() > skaicius)
                    {
                        aver = aver + 1;
                    }
                }

                var lyginiai = 0;

                foreach (int skaicius in sarasiukas)
                {
                    if (skaicius % 2 == 0)
                    {
                        lyginiai++;
                    }
                }

                Console.WriteLine("min" + sarasiukas.Min());
                Console.WriteLine("max" + sarasiukas.Max());
                Console.WriteLine("average" + sarasiukas.Average());
                Console.WriteLine("mazesni uz vid " + aver);
                Console.WriteLine("lyginiai " + lyginiai);
                foreach (int skaicius in sarasiukas)
                    Console.WriteLine(skaicius);
                Console.ReadKey();
            } 
    }
}
