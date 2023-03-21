using System;

namespace Basics
{
    public class Hard
    {
        /// <summary>
        /// Decode a binary in a string into its decimal representation
        /// </summary>
        /// <param name="s">String holding the binary</param>
        /// <returns>An int corresponding to the decimal representation of the
        /// binary</returns>
        public static int DecodeBinary(string s)
        {
            if (s == "" || s == "-")
            {
                return 0;
            }

            bool negativ = false;
            if (s[0] == '-')
            {
                negativ = true;
                (_, s) = Intermediate.SplitString(s, 0);
                //s = s[1..];
            }

            int result = 0;
            int i = s.Length-1;
            foreach (char test in s)
            {
                if (test == '1')
                {
                    result = result + (int) Core.MyPow(2,i);
                    i = i - 1;
                }
                else if (test == '0')
                {
                    i = i - 1;
                }
                else
                {
                    return -1;
                }
                
            }

            if (negativ)
            {
                result = result * -1;
            }
            return result;
        }

        /// <summary>
        /// Encode a decimal in binary
        /// </summary>
        /// <param name="n">An int that we want to convert in binary</param>
        /// <returns>A string holding the binary representation of n</returns>
        public static string EncodeBinary(int n)
        {
            string result = "";
            bool negativ = false;
            if (n < 0)
            {
                negativ = true;
                n = n * -1;
            }
            while (n > 0)
            {
                if (n % 2 == 1)
                {
                    result = "1" + result;
                }
                else
                {
                    result = "0" + result;
                }

                n = n / 2;

            }

            if (negativ)
            {
                result = "-" + result;
            }
            return result;
        }

        /// <summary>
        ///Decode a number written in octal in a string into its decimal representation
        /// </summary>
        /// <param name="s">String holding the octal</param>
        /// <returns>An int corresponding to the decimal representation of the octal</returns>
        public static int DecodeOctal(string s)
        {
            if (s == "" || s == "-")
            {
                return 0;
            }

            bool negativ = false;
            if (s[0] == '-')
            {
                negativ = true;
                (_, s) = Intermediate.SplitString(s, 0);
                //s = s[1..];
            }

            int result = 0;
            int i = s.Length-1;
            char [] digit = new []
            {
                '0', '1', '2', '3', '4', '5', '6', '7'
            };
            foreach (char test in s)
            {
                int index = 0;
                bool running = true;
                for (; running; index++)
                {
                    if (test == (digit[index]))
                    {
                        running = false;
                    }
                    else if (index == 7)
                    {
                        return -1;
                    }
                }

                result += (index-1) * (int) Core.MyPow(8, i);
                i = i - 1;

            }
            if (negativ)
            {
                result = result * -1;
            }
            return result;
        }

        /// <summary>
        /// Encode a decimal in octal
        /// </summary>
        /// <param name="n">An int that we want to convert in octal</param>
        /// <returns>A string holding the octal representation of n</returns>
        public static string EncodeOctal(int n)
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
            
            while (n > 0)
            {
                
                result = digit[n % 8] + result;
                n = n / 8;

            }

            if (negativ)
            {
                result = "-" + result;
            }
            return result;
        }
        
        /// <summary>
        ///Decode a number written in hexadecimal in a string into its decimal representation
        /// </summary>
        /// <param name="s">String holding the hexadecimal</param>
        /// <returns>An int corresponding to the decimal representation of the hexadecimal</returns>
        public static int DecodeHexa(string s)
        {
            if (s == "" || s == "-")
            {
                return 0;
            }

            s = s.ToUpper();

            bool negativ = false;
            if (s[0] == '-')
            {
                negativ = true;
                (_, s) = Intermediate.SplitString(s, 0);
                //s = s[1..];
            }

            int result = 0;
            int i = s.Length-1;
            char [] digit = new []
            {
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'a', 'b', 'c', 'd', 'e', 'f'
            };
            foreach (char test in s)
            {
                int index = 0;
                bool running = true;
                for (; running; index++)
                {
                    if (test == (digit[index]))
                    {
                        if (index > 15)
                        {
                            index -= 6;
                        }
                        running = false;
                    }
                    else if (index == 21)
                    {
                        return -1;
                    }
                }

                result += (index-1) * (int) Core.MyPow(16, i);
                i = i - 1;

            }
            if (negativ)
            {
                result = result * -1;
            }
            return result;
        }

        /// <summary>
        /// Encode a decimal in hexadecimal
        /// </summary>
        /// <param name="n">An int that we want to convert in hexadecimal</param>
        /// <returns>A string holding the hexadecimal representation of n</returns>
        public static string EncodeHexa(int n)
        {
            string result = "";
            bool negativ = false;
            if (n < 0)
            {
                negativ = true;
                n = n * -1;
            }
            
            string[] digit = new[]
            {
                "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"
            };
            
            while (n > 0)
            {
                
                result = digit[n % 16] + result;
                n = n / 16;

            }

            if (negativ)
            {
                result = "-" + result;
            }
            return result;
        
        }
    }
}