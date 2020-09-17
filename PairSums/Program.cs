using System;
using System.Collections;
using System.Collections.Generic;

/*
    Pair Sums
    Given a list of n integers arr[0..(n-1)], determine the number of different pairs of elements within it which sum to k.
    If an integer appears in the list multiple times, each copy is considered to be different; that is, two pairs are considered different if one pair includes at least one array index which the other doesn't, even if they include the same values.

    Signature
    int numberOfWays(int[] arr, int k)

    Input
    n is in the range [1, 100,000].
    Each value arr[i] is in the range [1, 1,000,000,000].
    k is in the range [1, 1,000,000,000].

    Output
    Return the number of different pairs of elements which sum to k.

    Example 1
    n = 5
    k = 6
    arr = [1, 2, 3, 4, 3]
    output = 2
    The valid pairs are 2+4 and 3+3.

    Example 2
    n = 5
    k = 6
    arr = [1, 5, 3, 3, 3]
    output = 4
    There's one valid pair 1+5, and three different valid pairs 3+3 (the 3rd and 4th elements, 3rd and 5th elements, and 4th and 5th elements).
*/

namespace PairSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test2 = new int[]{1, 2, 3, 4, 3}; //k=6, output =2
            int[] test3 = new int[]{1,5,3,3,3}; //k=6, output =4

            Console.WriteLine(method(test2, 6));
            Console.WriteLine(method(test3, 6));
        }

        //brute force
        private static int bruteForce(int[] arr, int k)
        {
            int counter = 0;
            for(int i=0;i<arr.Length -1;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]+arr[j] == k)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        private static int method(int[] arr, int k)
        {
            int counter = 0;

            //key = array value, value = occurrences
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for(int i=0;i<arr.Length;i++)
            {
                var currentValue = arr[i];

                if(dictionary.ContainsKey(k-currentValue))
                {
                    int occurrences = 0;
                    dictionary.TryGetValue(k-currentValue, out occurrences);
                    counter+= occurrences;
                }

                //if key exists, increment the value
                if(dictionary.ContainsKey(arr[i]))
                {
                    dictionary[arr[i]]++;
                }
                else
                {
                    dictionary.Add(arr[i], 1);
                }
            }
            return counter;
        }
    }
}
