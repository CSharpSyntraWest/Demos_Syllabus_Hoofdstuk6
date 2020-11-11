using System;

namespace StructCollectieGelijkheidNagaan
{
    enum Kleur { Schoppen, Klaveren, Harten, Ruiten }
    enum Nummer { Aas, Twee, Drie, Vier, Vijf, Zes, Zeven, Acht, Negen, Tien, Boer, Dame, Heer }
    class Program
    {

        static void Main()
        {
            Kaart kaart1 = new Kaart(Kleur.Ruiten, Nummer.Tien);
            Kaart kaart2 = kaart1; // kaart2 laten we wijzen naar hetzelfde object als kaart1
            Kaart kaart3 = new Kaart(Kleur.Ruiten, Nummer.Tien);


            Console.WriteLine(kaart1.Equals(kaart2));
            Console.WriteLine(!kaart1.Equals( kaart3));

        }
    }

        struct Kaart
        {
            public Kaart(Kleur kleur, Nummer nummer)
            {
                Kleur = kleur;
                Nummer = nummer;
            }
            public Kleur Kleur;
            public Nummer Nummer;
        }

}


