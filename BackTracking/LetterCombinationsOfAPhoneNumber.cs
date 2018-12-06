using System;
using System.Collections.Generic;
using System.Text;

namespace BackTracking
{
    /*
     * Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent.

        A mapping of digit to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.


        Example:

        Input: "23"
        Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
        Note:

        Although the above answer is in lexicographical order, your answer could be in any order you want.
     */
    public static class LetterCombinationsOfAPhoneNumber
    {
       static Dictionary<int, char[]> phoneNumberMapper = new Dictionary<int, char[]>();
       static List<string> result = new List<string>();
        public static IList<string> LetterCombinations(string digits)
        {
            if (digits.Length==0)
            {
                return result;
            }
            LoadMapper();
            StringBuilder sb = new StringBuilder();
            letterCombinationHelper(digits, sb);

                return result;
        }

        private static void letterCombinationHelper(string digits, StringBuilder sb)
        {
            if (sb.Length==digits.Length)
            {
                result.Add(sb.ToString());
                return;
            }

            foreach (var c in phoneNumberMapper[(Convert.ToInt32(digits[sb.Length].ToString()))])
            {
                sb.Append(c);
                letterCombinationHelper(digits, sb);
                sb.Remove(sb.Length - 1, 1);
            }
        }

        private static void LoadMapper()
        {
            
            phoneNumberMapper.Add(2, new char[] {'a','b','c' });
            phoneNumberMapper.Add(3, new char[] { 'd', 'e', 'f' });
            phoneNumberMapper.Add(4, new char[] { 'g', 'h', 'i' });
            phoneNumberMapper.Add(5, new char[] { 'j', 'k', 'l' });
            phoneNumberMapper.Add(6, new char[] { 'm', 'n', 'o' });
            phoneNumberMapper.Add(7, new char[] { 'p', 'q', 'r','s' });
            phoneNumberMapper.Add(8, new char[] { 't', 'u', 'v' });
            phoneNumberMapper.Add(9, new char[] {'w' ,'x', 'y', 'z' });
        }


        public static IList<string> LetterCombinations1(string digits)
        {
            IList<string> answs = new List<string>();
            if (digits == "") return answs;

            Dictionary<char, string> map = new Dictionary<char, string>()
            {
                {'2',"abc" },
                {'3',"def" },
                {'4',"ghi" },
                {'5',"jkl" },
                {'6',"mno" },
                {'7',"pqrs" },
                {'8',"tuv" },
                {'9',"wxyz" },
            };

            string answer = "";
            int index = 0;


            dfs(index, answer);
            return answs;

            void dfs(int currentIndex, string currentAnsw)
            {
                if (currentIndex == digits.Length)
                {
                    answs.Add(currentAnsw);

                    return;
                }
                foreach (char e in map[digits[currentIndex]])
                {
                    currentAnsw += e;

                    dfs(currentIndex + 1, currentAnsw);
                    currentAnsw = currentAnsw.Remove(currentAnsw.Length - 1);

                }
            }
        }
    }
}
