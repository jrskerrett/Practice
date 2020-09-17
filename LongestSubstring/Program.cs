using System;
using System.Collections.Generic;

namespace LongestSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Tests.Test("abcabcbb", 3));
            Console.WriteLine(Tests.Test("bbbbb", 1));
            Console.WriteLine(Tests.Test("pwwkew", 3));
            Console.WriteLine(Tests.Test("", 0));
            Console.WriteLine(Tests.Test("aab", 2));
            Console.WriteLine(Tests.Test("dvdf", 3));
        }

        public static int LongestSubstring(string s)
        {
            var set = new HashSet<char>();
            var winner = 0;
            var head = 0;
            var tail = 0;

            while(head < s.Length)
            {
                if(!set.Contains(s[head]))
                {
                    set.Add(s[head]);
                    head++;
                    winner = Math.Max(winner, set.Count);
                }
                else
                {
                    set.Remove(s[tail]);
                    tail++;
                }
            }
            return winner;
        }
    }

    class Tests
    {
        public static string Test(string s, int expectedOutput)
        {
           return Program.LongestSubstring(s) == expectedOutput ? "Pass" : $"Fail: {Program.LongestSubstring(s)}, should be {expectedOutput}";
        }
    }
}