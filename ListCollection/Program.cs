using System;
using System.Collections.Generic;

namespace ListCollection
{
    class Program
    {
        static void Main()
        {
            //In plaats van:
            //DateTime[] evenementen = new DateTime[2] {new DateTime(2020, 4, 17),
            //                                          new DateTime(2020, 5, 1)};
            //int aantal = 2;

            //Werken we met:
            List<DateTime> evenementen = new List<DateTime>(2) {
                               new DateTime(2020, 4, 17),
                               new DateTime(2020, 5, 1)};

            do
            {
                Console.WriteLine($"({evenementen.Capacity} elementen): ");
                for (int index = 0; index < evenementen.Count; index++)
                    Console.WriteLine("-> " + evenementen[index]);

                Console.Write("Nieuwe evenement datum?: ");
                DateTime nieuweDatum = DateTime.Parse(Console.ReadLine());
                //aantal = aantal + 1;
                Console.WriteLine();

                //We hoeven hier niet meer zelf de capaciteit aan te passen:
                //if (aantal > evenementen.Length)
                //{
                //    int nieuweCapaciteit = evenementen.Length * 2;
                //    Array.Resize(ref evenementen, nieuweCapaciteit);
                //}

                //Om daarna het element op de juist positie te plaastsen:
                //evenementen[aantal - 1] = nieuweDatum;

                //We roepen eenvoudigweg voor onze toe-te-voegen waarde de Add method aan:
                evenementen.Add(nieuweDatum);
            } while (true);
        }
    }
 }

