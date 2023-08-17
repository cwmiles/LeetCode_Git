using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Git.Leetcodeproblems
{
    internal class CanPlaceFlowersBitArray
    {
        /*
             * You have a long flowerbed in which some of the plots are planted, and some are not.
             * However, flowers cannot be planted in adjacent plots.
             * Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty,
             * and an integer n, return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.
             * 
             * Example 1:
             * Input: flowerbed = [1,0,0,0,1], n = 1
             * Output: true
             * 
             * Example 2:
             * Input: flowerbed = [1,0,0,0,1], n = 2
             * Output: false
             * 
             * Constraints:
             * 1 <= flowerbed.length <= 2 * 104 
             * flowerbed[i] is 0 or 1.
             * There are no two adjacent flowers in flowerbed.
             * 0 <= n <= flowerbed.length 
             * return false 
             */
        public bool CanPlaceFlowersOptimized(int[] flowerbed, int n)
        {
            int flowerCount = 0;
            int i = 0;

            while (i < flowerbed.Length)
            {
                if (flowerbed[i] == 0) //if bed is empty
                {
                    bool availableSpot = true;
                    if (i > 0 && flowerbed[i - 1] == 1) // checks to see previous spot is empty or planted 1|0
                    {
                        availableSpot = false;
                    }
                    if (i < flowerbed.Length - 1 && flowerbed[i + 1] == 1)
                    {
                        availableSpot = false;
                    }
                    if (availableSpot)
                    {
                        flowerbed[i] = 1;
                        flowerCount++;
                    }
                }
                if (flowerCount >= n)
                {
                    //allows us to break early
                    return true;
                }
                i++;
            }
            return flowerCount >= n;
        }

        public static int HelperFindTotalFlowers(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    count++;
                }
            }
            return count;
        }
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            //brute force check prvious and next flowerbeds
            //go through the list and keep count of how many flowers can be added
            int flowerCount = 0;
            int i = 0;
            while (i < flowerbed.Length)
            {
                if (flowerbed[i] == 0)
                {
                    // Check if the previous and next plots are also empty (or out of bounds)
                    bool prevEmpty = (i == 0) || (flowerbed[i - 1] == 0);
                    bool nextEmpty = (i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0);

                    if (prevEmpty && nextEmpty)
                    {
                        flowerbed[i] = 1; // Plant a flower
                        flowerCount++;
                    }
                }
                i++;
            }

            return flowerCount >= n;
        }
    }
}
