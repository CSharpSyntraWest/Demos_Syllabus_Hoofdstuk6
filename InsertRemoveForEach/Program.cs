using System;
using System.Collections.Generic;

namespace InsertRemoveForEach
{
    class Program
    {
        static void Main()
        {
            List<double> temperaturen = new List<double>() { 10.5, 13.4, 16.1 };

            temperaturen.Add(12.9);
            temperaturen.Insert(1, 6.7);
            temperaturen.Remove(13.4);
            temperaturen.RemoveAt(0);

            foreach (double temperatuur in temperaturen)
            {
                Console.WriteLine(temperatuur);
            }

        }

    }
}
