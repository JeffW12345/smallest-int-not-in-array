namespace CodilityChallenges
{
    using System;
    using System.Collections.Generic;

    class Solution
    {
        // Finds the smallest positive int to occur in the array
        public static int GetSmallestInt(int[] A)
        {
            HashSet<int> asSet = new HashSet<int>(A); // Convert to set to avoid repeating values
            if (!asSet.Contains(1))
            {
                return 1;
            }
            for (int i = 2; i < 1000000; i++)
            {
                if (!asSet.Contains(i))
                {
                    return i;
                }
            }
            return 1;
        }

        public static void Main(string[] args)
        {
            int[] arr = { 1, 3, 4, 3, 2 };
            Console.WriteLine(GetSmallestInt(arr));
        }
    }
}
