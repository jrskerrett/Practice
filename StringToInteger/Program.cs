using System;

namespace StringToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Tests.Test("+-2", 0));
            Console.WriteLine(Tests.Test("+", 0));
            Console.WriteLine(Tests.Test("", 0));
            Console.WriteLine(Tests.Test("   -42", -42));
            Console.WriteLine(Tests.Test("42", 42));
            Console.WriteLine(Tests.Test("4193 with words", 4193));
            Console.WriteLine(Tests.Test("words and 987", 0));
            Console.WriteLine(Tests.Test("-91283472332", -2147483648));
            Console.WriteLine(Tests.Test(".42", 0));
        }

        public static int MyAtoi(string str) {

            if(string.IsNullOrWhiteSpace(str))
            {
                return 0;
            }

            if(str.Length == 1 && !char.IsNumber(str[0]))
            {
                return 0;
            }

            var charArray = new char[str.Length];
            var intCounter = 0;
            bool signed = false;

            for(int i=0;i<str.Length;i++)
            {
                if(intCounter == 0 && !char.IsWhiteSpace(str[i]) && !char.IsNumber(str[i]) && str[i] != '-' && str[i] != '+')
                {
                    return 0;
                }
                if(intCounter == 1 && signed == true && !char.IsNumber(str[i]))
                {
                    return 0;
                }

                if( (str[i] == '-') || (str[i] == '+'))
                {
                    signed = true;
                    charArray[intCounter] = str[i];
                    intCounter++;
                }
                if(i < str.Length && Char.IsNumber(str[i]))
                {
                    while(i < str.Length && char.IsNumber(str[i]))
                    {
                        charArray[intCounter] = str[i];
                        intCounter++;
                        i++;
                    }
                    break;
                }
            }

            int test;
            try
            {
                test = int.Parse(charArray, System.Globalization.NumberStyles.AllowLeadingSign);
            }
            catch(System.OverflowException ex)
            {
                if(charArray[0] == '-')
                {
                    test = int.MinValue;
                }
                else
                {
                    test = int.MaxValue;
                }
            }
            return test;
        }
    }

    class Tests
    {
        public static string Test(string s, int expectedOutput)
        {
           return Program.MyAtoi(s) == expectedOutput ? "Pass" : $"Fail: {Program.MyAtoi(s)}, should be {expectedOutput}";
        }
    }
}