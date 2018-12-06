using System;
using System.Collections.Generic;
using System.Text;

namespace Other
{
    class HexToInt
    {
        // examples:
        // * 255 -> "ff"
        // *  31 -> "1f"
        // you can do itod if you want: 255 -> "255"
        // 0-9 -> 0-9
        // 10- A
        // 11- B
        // 2545 % 16 =1 //temp =1 hexa[0] = '1' 
        // 2545/16 = 159 1
        // n=159 ,i=12
        // 159/16 = 9  temp = 15 F
        // 9 %16 9 

        // 2^32 

        public static String itoh(int n)
        {
        

            if (n == 0 || n < 0) return "0";

            char[] hexa = new char[100];
            hexa[0] = 'A';
            int i = 0;
            while (n != 0)
            {
                //Temp var for storing the reminder of the Module 16
                int temp = 0;

                temp = n % 16;

                //Check if temp 
                if (temp < 10)
                {
                    hexa[i] = (char)(temp + 48);
                    i++;
                }
                // grater then 10 
                else
                {
                    hexa[i] = (char)(temp + 55);
                    i++;
                }
                //Add hexa result to dic
                n = n / 16; // n=159
            }

            int k = 0;
            int j = i - 1;
            while (j > k)
            {
                int t = hexa[j];
                hexa[j] = hexa[k];
                hexa[k] =(char) t;
                j--;
                k++;
            }
            return hexa.ToString();
        }
    }
}
