using System;
using System.Collections.Generic;

namespace FirstUniqueCharInString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = FirstUniqueCharInString("loveleetcode");
            Console.WriteLine(n);
            Console.ReadKey();
        }

        private static int FirstUniqueCharInString(string s)
        {
            Dictionary<Char, int> uniqDic = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (!uniqDic.ContainsKey(c))
                {
                    uniqDic.Add(c, 1);
                }
                else
                {
                    uniqDic[c]++;
                }
            }
            foreach (var u in uniqDic)
            {
                if (u.Value==1)
                {
                    return s.IndexOf(u.Key);
                }
            }
            //if (uniqDic.Values.Equals(1))
            //{
            //    return uniqDic.
            //}

            return -1;
        }
    }
}
