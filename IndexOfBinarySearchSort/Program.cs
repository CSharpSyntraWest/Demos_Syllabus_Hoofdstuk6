using System;

namespace IndexOfBinarySearchSort
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            List<double> temperaturen = new List<double>() { 10.5, 13.4, 16.1, 19.7 };
            List<string> steden = new List<string>() { "Oslo", "Praag", "Gent" };

            Console.WriteLine(steden.IndexOf("Gent"));          // index 2
            Console.WriteLine(temperaturen.BinarySearch(13.4)); // index 1

            steden.Sort();
            Console.WriteLine(steden.IndexOf("Gent"));          // index 0

        }
    }

}
