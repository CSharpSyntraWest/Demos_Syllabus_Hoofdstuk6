using System;

namespace WachtrijenEnStapels3
{
    using System;
    using System.Collections.Generic;
    class HaakjesTekst
    {
        public static List<Char> OpeningsHaakjes = new List<Char> { '(', '{', '[' };
        public static List<Char> SluitingsHaakjes = new List<Char> { ')', '}', ']' };
        public static bool IsCorrect(string tekst)
        {
            Stack<char> gevondenOpenHaakjes = new Stack<char>();
            foreach (char karakter in tekst)
            {
                if (OpeningsHaakjes.Contains(karakter))
                    gevondenOpenHaakjes.Push(karakter);
                else if (SluitingsHaakjes.Contains(karakter))
                {
                    if (gevondenOpenHaakjes.Count == 0 ||
                        OpeningsHaakjes.IndexOf(gevondenOpenHaakjes.Pop()) != SluitingsHaakjes.IndexOf(karakter))
                        return false;
                }
            }
            return gevondenOpenHaakjes.Count == 0;
        }
    }
    class Program
    {
        static void Main()
        {
            // Correct gebruik van haakjes:
            Console.WriteLine(HaakjesTekst.IsCorrect("abc"));
            Console.WriteLine(HaakjesTekst.IsCorrect("a(b)c"));
            Console.WriteLine(HaakjesTekst.IsCorrect("a(b)[c]"));
            Console.WriteLine(HaakjesTekst.IsCorrect("a[(b)]c"));
            Console.WriteLine(HaakjesTekst.IsCorrect("ab(c[d[e]fg]{hi})"));

            // Foutief gebruik van haakjes:
            Console.WriteLine(HaakjesTekst.IsCorrect("a)b(c"));
            Console.WriteLine(HaakjesTekst.IsCorrect("a(b]{c}"));
            Console.WriteLine(HaakjesTekst.IsCorrect("a(b))c"));
            Console.WriteLine(HaakjesTekst.IsCorrect("a(b)(c"));
            Console.WriteLine(HaakjesTekst.IsCorrect("a[(b])c"));
            Console.WriteLine(HaakjesTekst.IsCorrect("ab(c[d[e]fg]hi})"));
            Console.WriteLine(HaakjesTekst.IsCorrect("ab(c[d[efg]hi})"));

        }
    }

}
