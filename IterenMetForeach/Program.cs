using System;
using System.Collections.Generic;

namespace IterenMetForeach
{
    class Program
    {
        static void Main()
        {
            // Iteren over een double[] collectie via foreach kan:
            var temperaturen = new double[] { 10.2, 34.1, 17.5 };
            foreach (var temperatuur in temperaturen)
                Console.WriteLine(temperatuur);

            // Iteren over een List<string> collectie via foreach kan:
            var steden = new List<string> { "Antwerpen", "Brussel", "Gent" };
            foreach (var stad in steden)
                Console.WriteLine(stad);


        }

    }
}
