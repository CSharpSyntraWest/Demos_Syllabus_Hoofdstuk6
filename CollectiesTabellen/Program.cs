using System;

namespace CollectiesTabellen
{
    class Program
    {
        static void Main()
        {
            string namenLijst = @"Rita;Piet;Pol;Jacque;Jan;Mia;Jane;James";

            char[] splitKarakters = new char[] { ';', ',', '\n' };
            string[] namen = namenLijst.Split(splitKarakters);

            foreach (string naam in namen)
                Console.WriteLine(naam);
        }

    }
}
