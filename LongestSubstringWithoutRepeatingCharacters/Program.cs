using System;
using System.Collections.Generic;

namespace LongestSubstringWithoutRepeatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(lengthOfLongestSubstring("pwwker"));
            Console.ReadKey();
        }

        public static int LengthOfLongestSubstringBruteForce(string s)
        {
            int result = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int counter = 0;
            foreach (var c in s)
            {
                if (!dic.ContainsKey(c))
                {
                    counter++;
                    dic.Add(c, counter);

                }
                else
                {
                    if (result < counter)
                    {
                        result = counter;
                        counter = 0;
                        dic.Clear();
                        counter++;
                        dic.Add(c, counter);
                    }
                }
            }
            if (result < counter)
            {
                result = counter;
            }
            return result;
        }
        public static int lengthOfLongestSubstring(String s)
        {
            int n = s.Length;
            HashSet<char> set = new HashSet<char>();
            int ans = 0, i = 0, j = 0;
            while (i < n && j < n)
            {
                // try to extend the range [i, j]
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j++]);
                    ans = Math.Max(ans, j - i);
                }
                else
                {
                    set.Remove(s[i++]);
                }
            }
            return ans;
        }
    }
}
