﻿// Esimerkkiratkaisu tehtävää 1
// Pirkko Sutinen 13.4.2021
// pirkko.sutinen@sasky.fi

using System;

namespace tehtävä1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mikä sinun nimesi on?");
            string nimi = Console.ReadLine();
            Console.WriteLine("Minkä ikäinen olet?");
            string ika = Console.ReadLine();
            int ika = Convert.ToInt32(ika);
            int tulos;
            int iika;
            tulos = int.TryParse(ika, out iika);
            if(tulos)
            {
                Console.WriteLine($"Ajattele {nimi.ToUpper()}, vuonna 2031 olet jo {ika + 10} vuotta vanha");
            }
            else
            {
                Console.WriteLine("Anna ikä numerona");
                Console.ReadLine();
            }
        }
    }
}
