using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using namespace LeetCode_Git.Leetcodeproblems;
{
    public class ReverseVowelsOfString
{
    /* To run enter the below commands
         * string word1 = Console.ReadLine();
    
         * ReverseVowelsOfString.functionName(word1, word2);
         * */

    public string ReverseVowels(string s)
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