using System;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Tests.Test("III", 3));
            Console.WriteLine(Tests.Test("IV", 4));
            Console.WriteLine(Tests.Test("IX", 9));
            Console.WriteLine(Tests.Test("LVIII", 58));
            Console.WriteLine(Tests.Test("MCMXCIV", 1994));
        }

        public static int RomanToInt(string s) {

            var tempArray = new int[s.Length];
            int tempArrayCounter = 0;
            int modern;

            for(int i=1;i<s.Length;i++)
            {
                // do string to int conversion for current
                var current = Convert(s[i]);


                // detect subtraction
                if(isSubtraction(s[i-1], s[i]))
                {

                }

            }

            bool isSubtraction(char previous, char current)
            {
                if ((previous == 'I' && (current == 'V' || current == 'X'))
                 || (previous == 'X' && (current == 'L' || current == 'C'))
                 || (previous == 'C' && (current == 'D' || current == 'M')))
                 {
                     return true;
                 }
                 return false;
            }

            int Convert(char current)
            {
                switch(current){
                    case 'I':
                        return 1;
                    case 'V':
                        return 5;
                    case 'X':
                        return 10;
                    case 'L':
                        return 50;
                    case 'C':
                        return 100;
                    case 'D':
                        return 500;
                    case 'M':
                        return 1000;
                }
                return 0;
            }
        }
    }

    class Tests
    {
        public static string Test(string s, int expectedOutput)
        {
           return Program.RomanToInt(s) == expectedOutput ? "Pass" : $"Fail: {Program.RomanToInt(s)}, should be {expectedOutput}";
        }
    }
}
