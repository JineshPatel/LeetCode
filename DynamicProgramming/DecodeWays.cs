using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    /*
     * A message containing letters from A-Z is being encoded to numbers using the following mapping:

        'A' -> 1
        'B' -> 2
        ...
        'Z' -> 26
        Given a non-empty string containing only digits, determine the total number of ways to decode it.

        Example 1:

        Input: "12"
        Output: 2
        Explanation: It could be decoded as "AB" (1 2) or "L" (12).
        Example 2:

        Input: "226"
        Output: 3
        Explanation: It could be decoded as "BZ" (2 26), "VF" (22 6), or "BBF" (2 2 6).
     */
    public static class DecodeWays
    {
        public static int NumDecodings(string str)
        {
            if (string.IsNullOrEmpty(str)) return 0;   //Super base condition. No string = 0 ways.

            //Memoization initialization
            //dp array of size n + 1 to save subproblem solutions, dp[n] will be the end result.
            int n = str.Length;
            int[] dp = new int[n + 1];
            dp[0] = 1;                        //Empty string will have one way to decode
            dp[1] = str[0] != '0' ? 1 : 0;   //if only 1 char in the string, if Valid; return 1.

            for (int i = 2; i <= n; i++)
            {
                if (str[i - 1] > '0')       //If valid, count it.
                    dp[i] += dp[i - 1];
                if (str[i - 2] == '1' || (str[i - 2] == '2' && str[i - 1] < '7')) //if in valid range: 10 to 26, count it.
                    dp[i] += dp[i - 2];
            }

            return dp[n];
        }

        private static int NumDecodingsHelper(string data, int k, int[] memo)
        {
            //base cases
            if (k==0)
            {
                return 1;
            }
            int s = data.Length - k;//to find if first element is 0 or not
            if (Convert.ToInt32(data[s].ToString()) == 0)
            {
                return 0;
            }
            if (memo[k]!=0)
            {
                return memo[k];
            }
            int result = NumDecodingsHelper(data, k - 1, memo);

            if (k>=2 && Convert.ToInt32( data.Substring(0,2) )<=26)
            {
                result = result + NumDecodingsHelper(data, k - 2, memo);
            }
            memo[k] = result;
            return result;
        }

        static int countDecoding(char[] digits, int n, int[] memo)
        {

            // base cases 
            if (n == 0 )
                return 1;
            if (memo[n] != 0)
            {
                return memo[n];
            }
            // Initialize count 
            int count = 0;

            // If the last digit is not 0, then  
            // last digit must add to 
            // the number of words 
            if (digits[n - 1] > '0')
                count = countDecoding(digits, n - 1,memo);

            // If the last two digits form a number 
            // smaller than or equal to 26, then  
            // consider last two digits and recur 
            if (digits[n - 2] == '1' ||
                        (digits[n - 2] == '2' &&
                           digits[n - 1] < '7'))
                count += countDecoding(digits, n - 2,memo);
            memo[n] = count;
            return count;
        }

    }
}
