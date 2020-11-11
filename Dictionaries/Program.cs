using System;

namespace Dictionaries
{
    using System;
    using System.Collections.Generic; // nodig voor Dictionary<TKey, TValue>

    class Program
    {
        static void Main()
        {
            Artikel artikel1 = new Artikel("Spa Mint 50cl", 0.68m);
            Artikel artikel2 = new Artikel("Orval 33cl", 1.10m);

            string barcode1 = "98765432";
            string barcode2 = "23456789";

            Dictionary<string, Artikel> catalogus1 = new Dictionary<string, Artikel>();
            catalogus1.Add(barcode1, artikel1);
            catalogus1.Add(barcode2, artikel2);

            // Itereren over de volledige dictionary:
            foreach (KeyValuePair<string, Artikel> entry in catalogus1)
            {
                Artikel value = entry.Value;

                Console.WriteLine($"{entry.Key }: Naam={value.Naam}, Prijs={value.Prijs}");
            }
            // Opvragen van bijhorende value van bepaalde sleutel:
            Artikel artikelX = catalogus1[barcode1];
            Console.WriteLine($"Artikel met code {barcode1}: Naam={artikelX.Naam}, Prijs={artikelX.Prijs}");

            //Dictionary<string, Artikel> catalogus2 = new Dictionary<string, Artikel>
            //      { { "98765432", new Artikel("Spa Mint 50cl", 0.68m) } };
            //Artikel artikelY = catalogus2["98765432"];
            //Console.WriteLine(artikelY.Naam + "," + artikelY.Prijs);
            //List<string> weekdagen = new List<string> { "Maandag", "Dinsdag", "..." };
            //string weekdagY = weekdagen[1];              // indexer
            //Console.WriteLine(weekdagY);                 // Dinsdag

            //Console.WriteLine(catalogus1.ContainsKey(barcode2));
            //Console.WriteLine(catalogus1.ContainsValue(artikel2));
            //catalogus1.Remove(barcode1);
            //Console.WriteLine(catalogus1.Count);   // 1 minder

            //catalogus1.Clear();
            //Console.WriteLine(catalogus1.Count);   // 0

        }
    }

    struct Artikel
    {
        public Artikel(string naam, decimal prijs)
        {
            Naam = naam;
            Prijs = prijs;
        }
        public string Naam;
        public decimal Prijs;

    }
}
