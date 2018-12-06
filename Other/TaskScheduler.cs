using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Other
{
   public static class TaskScheduler
    {
        /*Given a char array representing tasks CPU need to do. It contains capital letters A to Z where different letters represent different tasks.Tasks could be done without original order. Each task could be done in one interval. For each interval, CPU could finish one task or just be idle.

        However, there is a non-negative cooling interval n that means between two same tasks, there must be at least n intervals that CPU are doing different tasks or just be idle.

        You need to return the least number of intervals the CPU will take to finish all the given tasks.

 

        Example:

        Input: tasks = ["A","A","A","B","B","B"], n = 2
        Output: 8
        Explanation: A -> B -> idle -> A -> B -> idle -> A -> B.
         * ****************************Algo************************
         * Idea is to create a dictionary of all the characters with the count and then sort them in the descending order.
            iteration = (N + 1 ) X (max character count - 1) + (# of characters with the max count)
            e.g.
            AAABBB and n =4
            AB---AB---AB
            (AB---) represents N + 1
            (AB---) is happening 2 times so 3-1
            AB last 2 characters represents
                     */
        public static int LeastInterval(char[] tasks, int n)
        {
            // Early return if the n is 0
            if (n == 0) return tasks.Length;

            // Create a dictionary
            Dictionary<char, int> d = new Dictionary<char, int>();

            // Add values into dictionary
            foreach (char c in tasks)
            {
                if (!d.ContainsKey(c))
                    d.Add(c, 0);
                d[c]++;
            }
            // Sort them
            d = d.OrderByDescending(c => c.Value).ToDictionary(c => c.Key, c => c.Value);

            // Get the max count 
            int max = d.First().Value;

            // All max count 
            int count = d.Count(c => c.Value == max);
            // expected iteraiton
            int iteration = (n + 1) * (max - 1) + count;

            // iteration should be greater than task length
            return (iteration >= tasks.Length) ? iteration : tasks.Length;
        }
    }
}
