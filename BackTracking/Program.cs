using System;

namespace BackTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //   var test = LetterCombinationsOfAPhoneNumber.LetterCombinations1("23");

            //    var t2 = FindSubsets.Subsets(new int[] { 1, 2, 3 });

            Permutations.PermutationOfString("abc");


            //Permutations.PermutationOfInt(new int[] { 1, 1, 2 });


            Permutations2 permutations2 = new Permutations2();
            var test = permutations2.PermuteUnique(new int[] { 1, 1, 2 });

            var result=  RemoveInvalidParanthesis.removeInvalidParenthesisBFS("(a)())()");

            var match = WildCardMatching.isMatch("aa", "aa");
            Console.ReadKey();
        }
    }
}
