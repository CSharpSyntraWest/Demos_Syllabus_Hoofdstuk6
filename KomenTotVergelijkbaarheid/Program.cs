using System;

namespace KomenTotVergelijkbaarheid
{
    class Program
    {
        static void Main()
        {
            int[] verzameling1 = { 20, 10, 30 };
            string[] verzameling2 = { "wereld", "hallo" };
            DateTime[] verzameling3 = { new DateTime(2020, 8, 31),
                                            new DateTime(2016, 11, 28) };

            Array.Sort(verzameling1);
            Array.Sort(verzameling2);
            Array.Sort(verzameling3);

            Print(verzameling1);
            Print(verzameling2);
            Print(verzameling3);

        }
        static void Print(Array verzameling)
        {
            foreach (object element in verzameling) Console.Write(element + " ");
            Console.WriteLine();
        }

    }
}
