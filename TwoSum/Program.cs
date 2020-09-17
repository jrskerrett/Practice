using System;
using System.Collections;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Tests.Test(new int[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 }));
            Console.WriteLine(Tests.Test(new int[] { 3, 2, 4 }, 6, new[] { 1, 2 }));
            Console.WriteLine(Tests.Test(new int[] { 3, 3 }, 6, new[] { 0, 1 }));
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            var ht = new Hashtable();
            for(int i=0;i<nums.Length;i++)
            {
                if()
            }
        }
    }

    class Tests
    {
        public static string Test(int[] nums, int target, int[] expectedOutput)
        {
           return Program.TwoSum(nums, target) == expectedOutput ? "Pass" : $"Fail: {Program.TwoSum(nums, target)}, should be {expectedOutput}";
        }
    }
}
