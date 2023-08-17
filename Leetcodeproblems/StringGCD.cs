using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Git.Leetcodeproblems
{
    public class StringGCD
    {
        static int FindGCDofStrings(int lengthOfStr1, int lengthOfStr2)
        {
            while (lengthOfStr2 != 0)
            {
                int temp = lengthOfStr2;
                lengthOfStr2 = lengthOfStr1 % lengthOfStr2;
                lengthOfStr1 = temp;
            }
            return lengthOfStr1;
        }

        public static void LargestCommonDivisor(string str1, string str2)
        {
            /* This method is better for shorter words, but for longer user a more efficient
             * Algorithm like the method below
             */
            int len1 = str1.Length;
            int len2 = str2.Length;
            int gcdLength = FindGCDofStrings(len1, len2);

            string substr1 = str1.Substring(0, gcdLength);
            string substr2 = str2.Substring(0, gcdLength);

            if (substr1 == substr2)
            {
                Console.WriteLine($"The Greatest Common Denominator is: {substr1}");
            }
            else
            {
                Console.WriteLine("Nothing - Was found.");
            }
        }

        public static void LargestCommonDivisorMid(string str1, string str2)
        {
            /*str1+str2 == str2+str1 if and only if str1 and str2 have a gcd .
             *E.g. str1=abcabc, str2=abc, then str1+str2 = abcabcabc = str2+str1
             *
             *This(str1+str2==str2+str1) is a requirement for the strings to have a gcd. 
             *If one of them is NOT a common part then gcd is "".It means we will return empty string
             *
             *Proof:-str1 = mGCD, str2 = nGCD, str1 + str2 = (m + n)GCD = str2 + str1
             *Both the strings are made of same substring added multiple times.
             *Since they are multiples, next step is simply to find the gcd of the lengths of 2 strings e.g. gcd(6,3) = 3, 
             *(we can use gcd function to find that)and get the substring of length 3 from either str1 or str2.
             *In c++ it will be str1.substr(0, gcd)
             */
            if (str1 + str2 != str2 + str1)
            {
                Console.WriteLine("No Divisor");
             //   return "";
            }

            int len1 = str1.Length;
            int len2 = str2.Length;
            int gcdLength = FindGCDofStrings(len1, len2);

            Console.WriteLine(str1.Substring(0, gcdLength));
            //return str1.Substring(0, gcdLength);
        }
        public static void LargestCommonDivisorOptimized(string str1, string str2)
        {
            /*
             * Here we copare characters from the beginning of both strings up to the GCD length.
             * For mismatched characters, we return an empty string, saying it cant be divided.
             * If not, we return the substr1 which is the largest string that divides both strings entered.
             * This avoids substr exraction -> therefore more efficient
             */
            int len1 = str1.Length;
            int len2 = str2.Length;
            int gcdLength = FindGCDofStrings(len1, len2);

            for (int i = 0; i < gcdLength; i++)
            {
                if (str1[i] != str2[i])
                {
                    Console.WriteLine("Nothing - Was found.");
                    //return "";
                }
            }
            Console.WriteLine($"The Greatest Common Denominator is: {str1.Substring(0,gcdLength)}");
            //return str1.Substring(0, gcdLength);
        }

    }
}
