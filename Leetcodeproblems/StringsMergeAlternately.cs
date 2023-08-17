using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Git.Leetcodeproblems
{
    public class StringsMergeAlternately
    {
        /* To run enter the below commands
         * string word1 = Console.ReadLine();
         * string word2 = Console.ReadLine();
         * StringsMergeAlternately.MergeAlternately(word1, word2);
         * */


        //Learned in this that Stringbuilder is better for 1000+ strings char arracys and Concat is better otherwise. String builder has a long startup time.
        public static void MergeAlternately(string word1, string word2)
        {
            int count = 0;
            char[] charword1 = word1.ToCharArray();
            char[] charword2 = word2.ToCharArray();
            string result = "";
            while (count <= 100 && (count < word1.Length || count < word2.Length))
            {
                if (count < word1.Length)
                {
                    result = String.Concat(result, charword1[count]);
                }
                if (count < word2.Length)
                {
                    result = String.Concat(result, charword2[count]);
                }
                count++;
            }
            Console.WriteLine("The resulting joined string is: " + result);
        }
    }
}
