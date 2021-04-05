using System;
using System.Collections.Generic;
using System.Text;

namespace program1
{
    class SumOfTriplets
    {
        public static void FindTriplets()
        {
            bool found = false;
            int[] array = { 12, 6, -6, 4, 5, 10 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    for (int k = j+1; k < array.Length; k++)
                    {
                        if (array [i] + array [j] + array [k] == 0)
                        {
                            found = true;
                            Console.WriteLine("[" + array[i] + "," + array[j] + "," + array[k] + "]");
                        }
                    }
                }
            }
            if (found == false)
                Console.WriteLine("Triplets not present in the given array");
        }
        public static void FindTripletsWithHasSet()
        {
            bool found = false;
            int[] array = { 12, 6, -6, 4, 5, 10 };

            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int thirdValue= -(array[i] + array[j]);
                    if(set.Contains(thirdValue))
                    {
                        Console.WriteLine("[" + array[i] + "," + array[j] + "," + thirdValue + "]");
                        found = true;
                    }
                    else
                    {
                        set.Add(array[j]);
                    }
                }
            }
            if (found == false)
                Console.WriteLine("Triplets not present in the given array");
        }
    }
}
