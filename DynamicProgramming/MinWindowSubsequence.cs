using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicProgramming
{
    public static class MinWindowSubsequence
    {
        public static string MinWindow(string S, string T)
        {
            if (S.Length==0)
            {
                return "";
            }
            int j = 0;
            Dictionary<int, string> minwindows = new Dictionary<int, string>();
            int startingIndex = -1; int endIndex = -1;
            for (int i = 0; i < S.Length; i++)
            {
                if (j < T.Length)
                {
                    //if (S[i]==T[0])
                    //{
                    //    startingIndex = i;
                    //}
                    if (S[i] == T[j])
                    {
                        if (j == 0)
                        {
                            startingIndex = i;
                        }
                        j++;
                    }
                }
                if (j == T.Length )
                {
                    endIndex = i;
                    i = startingIndex;
                    j = 0;
                    //if (endIndex==S.Length)
                    //{
                    //    endIndex = S.Length - 1;
                    //}
                    if (!minwindows.ContainsKey(endIndex - startingIndex + 1))
                    {
                        minwindows.Add(endIndex - startingIndex + 1, S.Substring(startingIndex, endIndex - startingIndex + 1));
                    }
                    
                }
            }
            if (minwindows.Count==0)
            {
                return "";
            }
            return minwindows[minwindows.Keys.Min()];
        }
    }
}
