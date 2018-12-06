using System;
using System.Collections.Generic;
using System.Text;

namespace Other
{
    /*
     * : Keep subtracting the divisor from dividend until dividend becomes less than divisor. 
     * The dividend becomes the remainder, and the number of times subtraction is done becomes the quotient.
     * Below is the implementation of above approach 
     */
    public static class DivideTwoIntegers
    {
        public static int divide(int dividend, int divisor)
        {
            int sign = ((dividend < 0) || (divisor < 0)) ? -1 : 1;
            int couter = 0;

            dividend = Math.Abs(dividend);
            divisor = Math.Abs(divisor);

            while (dividend>=divisor)
            {
                dividend = dividend - divisor;
                
                couter++;
            }

            return sign * couter;
        }
    }
}
