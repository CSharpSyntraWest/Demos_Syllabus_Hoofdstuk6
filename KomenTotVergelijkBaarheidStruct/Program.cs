using System;

namespace KomenTotVergelijkBaarheidStruct
{
    struct Bestand
    {
        public string Naam;
        public string Type;
    }

    class Program
    {
            static void Main()
            {
                var b1 = new Bestand { Naam = "Recept", Type = ".doc" };
                var b2 = new Bestand { Naam = "Handleiding", Type = ".txt" };
                var b3 = new Bestand { Naam = "Handleiding", Type = ".doc" };

                Bestand[] verzameling4 = { b1, b2, b3 };

                //InvalidOperationException: Failed to compare two elements in the array.
                Array.Sort(verzameling4);
            }

    }
}
