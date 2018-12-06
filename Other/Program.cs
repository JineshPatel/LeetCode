using System;

namespace Other
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DivideTwoIntegers.divide(7,-3));
            Console.WriteLine(TaskScheduler.LeastInterval(new char[] { 'A', 'A', 'A', 'B', 'B', 'B','B' }, 2));
            Console.WriteLine(HexToInt.itoh(2545));
            Console.ReadKey();
        }
    }
}
