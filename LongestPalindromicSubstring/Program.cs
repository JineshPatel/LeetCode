using System;
/*
 * Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.

Example 1:

Input: "babad"
Output: "bab"
Note: "aba" is also a valid answer.
Example 2:

Input: "cbbd"
Output: "bb"

 * */
namespace LongestPalindromicSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LPS("banana"));
            Console.ReadKey();
        }

        public static string LPS(string s)
        {
            int n = s.Length;
            int palindrpmeBeginsAt = 0;
            int max_len = 1;
            bool[,] palindrome = new bool[n, n];

            //Make Single Letter True
            for (int i = 0; i < n; i++)
            {
                palindrome[i, i] = true;
            }
            for (int i = 0; i < n-1; i++)
            {
                if (s[i]==s[i+1])
                {
                    palindrome[i, i + 1] = true;
                    palindrpmeBeginsAt = i;
                    max_len = 2;
                }
            }

            for (int curr_len = 3; curr_len < n; curr_len++)
            {
                for (int i = 0; i < n-curr_len+1; i++)
                {
                    int j = i + curr_len - 1;
                    if (s[i]==s[j] && palindrome[i+1,j-1])
                    {
                        palindrome[i, j] = true;
                        palindrpmeBeginsAt = i;
                        max_len = curr_len;
                    }
                }

                
            }

            return s.Substring(palindrpmeBeginsAt, max_len + 1);
        }

    }
}
