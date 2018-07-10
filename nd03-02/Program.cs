using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nd03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] kordinaciusTaskaiX ={ 5, 9, 8, 7, 2, 56, 9, 9, 9, 9, 5, 5, 3, 2, 5 };
            int[] kordinaciusTaskaiY = { 4, 8, 1, 5, 25, 4, 5, 5, 5, 5, 8, 7, 9, 3, 6 };
            Console.WriteLine("Prasome ivesti apskritimo centro x kordinate:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prasome ivesti apskritimo centro y kordinate:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prasome ivesti apskritimo spinduli:");
            int r = Convert.ToInt32(Console.ReadLine());
            var taskuSkaicius = 0;

            for (int i = 0; i< kordinaciusTaskaiX.Length; i++)
            {
                if (kordinaciusTaskaiX[i] <= x + r && kordinaciusTaskaiX[i] >= x - r)
                {
                    if (kordinaciusTaskaiY[i] <= y+r && kordinaciusTaskaiY[i] >= y-r)
                    {
                        taskuSkaicius += 1;
                    }
                        
                            }

            }
            Console.WriteLine("Pakliunanciu tasku skaicius: " + taskuSkaicius);
            Console.ReadKey();
        }
    }
}
