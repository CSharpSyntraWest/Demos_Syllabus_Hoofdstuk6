using System;
using System.Collections.Generic;

namespace CollectiesListIndexer
{
    class Program
    {
        static void Main()
        {
            int[] eenArray = new int[] { 10, 20, 30 };
            List<int> eenList = new List<int>() { 100, 200, 300 };

            eenArray[1] += 1;
            eenList[1] += 1;

            for (int index = 0; index < eenArray.Length; index++)
                Console.WriteLine(eenArray[index]);

            for (int index = 0; index < eenList.Count; index++)
                Console.WriteLine(eenList[index]);
        }

    }
}
