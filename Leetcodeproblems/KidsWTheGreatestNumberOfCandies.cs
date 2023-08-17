using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Git.Leetcodeproblems
{
    #region Description of Problem
    /*
     * There are n kids with candies. You are given an integer array candies, where each candies[i] represents the number of candies the ith kid has, 
     * and an integer extraCandies, denoting the number of extra candies that you have.
     * Return a boolean array result of length n, where result[i] is true if, after giving the ith kid all the extraCandies,
     * they will have the greatest number of candies among all the kids, or false otherwise.
     * Note that multiple kids can have the greatest number of candies.
     * 
     * Constraints:
     *     n == candies.length
     *     2 <= n <= 100
     *     1 <= candies[i] <= 100
     *     1 <= extraCandies <= 50
     */
    #endregion
    public class KidsWTheGreatestNumberOfCandies
    {
        /*
         * BEST RUNTIME BELOW
         */
        public static IList<bool> KidsWithCandiesBestRunTime(int[] candies, int extraCandies) {
            int maxNum = FindMax(candies);  // Call a separate method to find the maximum value
            int n = candies.Length;
            IList<bool> result = new List<bool>(n);
            for (int i = 0; i < n; i++)
            {
                result.Add(candies[i] + extraCandies >= maxNum);
                //candies[i] = (candies[i] + extraCandies >= maxNum) ? 1 : 0;  
            }

            return result;
        }


        public static int FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        /*
         * Decent MEMORY 
         */
        public static IList<bool> KidsWithCandiesBestMemory(int[] candies, int extraCandies)
        {
            int maxNum = candies.Max();  // Call a separate method to find the maximum value
            int n = candies.Length;
            IList<bool> result = new List<bool>(n);
            for (int i = 0; i < n; i++)
            {
                result.Add(candies[i] + extraCandies >= maxNum);
                //candies[i] = (candies[i] + extraCandies >= maxNum) ? 1 : 0;  
            }

            return result;
        }
        #region Extra Methods...


        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> boolResult = new List<bool>(candies.Length);
            int maxNum = candies.Max();
            foreach (var numOfCandy in candies)
            {
                boolResult.Add(numOfCandy + extraCandies >= maxNum);
            }
            return boolResult;
        }

        public static IList<bool> KidsWithCandies2(int[] candies, int extraCandies)
        {
            IList<bool> boolResult = new List<bool>(candies.Length);
            int maxNum = candies.Max();
            foreach (var numOfCandy in candies)
            {
                if ((numOfCandy + extraCandies) >= maxNum)
                {
                    boolResult.Add(true);
                }
                else
                {
                    boolResult.Add(false);
                }
            }
            return boolResult;
        }
        public static IList<bool> KidsWithCandies3(int[] candies, int extraCandies)
        {
            int maxNum = candies.Max();
            bool[] boolResult = new bool[candies.Length];

            for (int i = 0; i < candies.Length; i++)
            {
                boolResult[i] = (candies[i] + extraCandies) >= maxNum;
            }

            return boolResult;
        }


        public static IList<bool> KidsWithCandiesOneLiner(int[] candies, int extraCandies)
        {
            return candies.Select(x => x + extraCandies >= candies.Max()).ToArray();


            /*
             * candies is an array of integers representing the number of candies each kid has.
             * extraCandies is an integer representing the extra candies a kid can have.
             * 
             * Here's what the code does:
             * The Select method from LINQ is used to project each element in the candies array to a boolean value.
             * The projection is done using a lambda function: x => x + extraCandies >= candies.Max().
             * x represents each individual element (number of candies) in the candies array.
             * candies.Max() returns the maximum value in the candies array, which represents the maximum number of candies any kid has.
             * The lambda function checks whether adding extraCandies to the current number of candies (x) makes it greater than or equal to the maximum number of candies (candies.Max()).
             * The result of this comparison is a boolean value (true or false).
             * The Select method applies this lambda function to each element in the candies array, creating an IEnumerable of boolean values.
             * ToArray() is used to convert the IEnumerable of boolean values into an array of booleans.
             * The resulting array of booleans indicates for each kid whether they will have the greatest number of candies when extraCandies are added.
             * In summary, the code uses LINQ's Select method to generate an array of boolean values,
             * where each boolean represents whether a kid will have the greatest number of candies among all kids when extraCandies are added to their initial amount. 
             */
        }
        #endregion

    }
}
