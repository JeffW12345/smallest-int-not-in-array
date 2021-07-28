namespace CodilityChallenges
{
    using System;
    using System.Collections.Generic;

    class Solution
    {
        // Finds the smallest positive int to occur in the array
        public static int GetSmallestInt(int[] A)
        {
            List<int> asList = new List<int>(A);
            for (int i = 1; i < 1000000; i++)
            {
                if (!asList.Contains(i))
                {
                    return i;
                }
            }
            return 1;
        }

        public static void Main(string[] args)
        {
            int[] arr = { 1, 3, 4, 3, -4 };
            Console.WriteLine(GetSmallestInt(arr));
        }
    }
}
