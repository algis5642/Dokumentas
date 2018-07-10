using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_00_pavyzdziai
{
    class Gyvunas
    {

        public string KailioSpalva { get; private set; }
        public string KailioIlgis { get; set; }
        public int KojuKiekis { get; private set; }
        public int Amzius { get; private set; }

        public Gyvunas()
        {

        }
        public Gyvunas(string kailioSpalva, string kailioIlgis, int kojuKiekis, int amzius)
        {
            KailioIlgis = kailioIlgis;
            KailioSpalva = kailioSpalva;
            KojuKiekis = kojuKiekis;
            Amzius = amzius;
        }

        public void isvedimas()
        {
            Console.WriteLine("Kailis"+ KailioSpalva);
            Console.WriteLine("Kailio ilgis" + KailioIlgis);
            Console.WriteLine("Koju kiekis" +KojuKiekis);
            Console.WriteLine("amzius" +Amzius);

        }

        public void Gimtadienis()
        {
            Amzius++;
        }
    }
}
