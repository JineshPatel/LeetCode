using System;

namespace AddBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddTwoBinary("1010","10101"));
            Console.ReadKey();
        }

        public static string AddTwoBinary(string a,string b)
        {
            string result = "";

            int s = 0;

            int i = a.Length - 1;
            int j = b.Length - 1;
            while (i>=0 || j>=0 ||s==1)
            {
                s = s + ((i >= 0) ? a[i] - '0' : 0);
                s = s + ((j >= 0) ? b[j] - '0' : 0);

                result = (char)(s % 2 + '0') + result;

                s = s / 2;

                i--;j--;
            }

            return result;
        }
    }
}
