using System;

namespace ValidPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "abca";
            Console.WriteLine(IsPalindrome(inputString));
            Console.WriteLine(validPalindrome(inputString));
        }

        public static bool IsPalindrome(string s)
        {
            //One pointer in the fron and one in the end
            int i = 0;

            //remove white space.
           s= s.Replace(" ", string.Empty).ToLower();
          //  s = System.Text.RegularExpressions.Regex.Replace(s, "[^A-Za-z0-9]", "");
           
            int j = s.Length - 1;
            while (i < j)
            {

                //Check if it's char or not
               // if (((s[i] >= 'a' && s[i] <= 'z')) && ((s[j] >= 'a' && s[j] <= 'z')))
                {
                    if (s[i] == s[j])
                    {
                        i++;
                        j--;
                    }
                    else
                    {
                        return false;
                    }
                }
                //else
                //{
                //    i++;
                //    j--;
                //}
            }

            return true;
        }
        /*
         Given a non-empty string s, you may delete at most one character. Judge whether you can make it a palindrome.
            Example 1:
            Input: "aba"
            Output: True
            Example 2:
            Input: "abca"
            Output: True
            Explanation: You could delete the character 'c'.
            Note:
            The string will only contain lowercase characters a-z. The maximum length of the string is 50000.
         */

        public static bool validPalindrome(String s)
        {
            if (s == null || s.Length==0) return true;
            return checkValid(s, 0, s.Length - 1, false);
        }

        private static bool checkValid(String s, int i, int j, bool hasDelete)
        {
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    if (hasDelete) return false;
                    return checkValid(s, i + 1, j, true) || checkValid(s, i, j - 1, true);
                }
                else
                {
                    i++;
                    j--;
                }
            }
            return true;
        }
    }
}
