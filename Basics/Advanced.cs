using System;

namespace Basics
{
    public class Advanced
    {
        /// <summary>
        /// Convert an number written in a string into the corresponding int
        /// </summary>
        /// <param name="num">String of the number</param>
        /// <returns>An int of the number contained in the string</returns>
        public static int Atoi(string num)
        {
            if (num == "" || num == "-")
            {
                return -1;
            }
            char [] digit = new []
            {
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };
            int len = digit.Length;
            int result = 0;
            bool negativ = false;
            if (num[0] == '-')
            {
                negativ = true;
                (_, num) = Intermediate.SplitString(num, 0);
                ///num = num[1..];
            }
            foreach (char test in num)
            {
                int index = 0;
                bool running = true;
                for (; running; index++)
                {
                    if (test == (digit[index]))
                    {
                        result += index;
                        running = false;
                    }
                    else if (index == 9)
                    {
                        return -1;
                    }

                }

                result = result * 10;
            }

            if (negativ)
            {
                result = result * -1;
            }
            return result/10;
        }

        /// <summary>
        /// Convert an int into its string representation 
        /// </summary>
        /// <param name="n">Int that we want to convert</param>
        /// <returns>A string representation of n</returns>
        public static string Itoa(int n)
        {
            if (n == 0)
            {
                return "0";
            }
            string result = "";
            bool negativ = false;
            if (n < 0)
            {
                negativ = true;
                n = n * -1;
            }
            string[] digit = new[]
            {
                "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
            };
            int uni = new int();
            for (; n > 0; n = n / 10)
            {
                uni = n % 10;
                result = digit[uni] + result;
            }

            if (negativ)
            {
                result = "-" + result;
            }
            return result;
        }
    }
}