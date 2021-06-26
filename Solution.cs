namespace CodilityChallenges
{
    using System;
    using System.Collections.Generic;

    class Solution
    {
        // Finds the smallest int not to occur in the array
        public static int solution(int[] A)
        {
            List<int> asList = new List<int>(A);
            asList.Sort();
            int minPositiveInList = 0;
            foreach (int num in asList)
            {
                if (num > 0)
                {
                    minPositiveInList = num;
                    break;
                }
            }
            if (minPositiveInList >= 2 || minPositiveInList <= 0)
            {
                return 1;
            }
            if (minPositiveInList == 1)
            {
                int firstOccurrence = asList.IndexOf(1);
                for (int i = firstOccurrence + 1; i < asList.Count; i++)
                {
                    if (asList[i] == asList[i - 1] + 1 || asList[i] == asList[i - 1])
                    {
                        minPositiveInList++;
                    }
                    else
                    {
                        return minPositiveInList;
                    }
                }
            }
            return minPositiveInList + 1;
        }

        public static void Main(string[] args)
        {

            int[] arr = { 1, 3, 4, 3, 2 };
            Console.WriteLine(solution(arr));
        }
    }
}
