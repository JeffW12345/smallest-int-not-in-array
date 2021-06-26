namespace CodilityChallenges
{
    using System;
    using System.Collections.Generic;

    class Solution
    {
        // Finds the smallest int not to occur in the array
        public static int GetSmallestInt(int[] A)
        {
            HashSet<int> asSet = new HashSet<int>(A);
            int minPositiveInList = 0;
            foreach (int num in asSet)
            {
                if (num > 0)
                {
                    if(num < minPositiveInList && minPositiveInList > 0)
                    {
                        minPositiveInList = num;
                    }
                    if(minPositiveInList == 0)
                    {
                        minPositiveInList = num;
                    }
                }
            }
            if (minPositiveInList != 1)
            {
                return 1;
            }
            for(int i = 1; i < 1000000; i++)
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
