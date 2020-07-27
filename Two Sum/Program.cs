using System;
using System.Collections.Generic;
using System.Linq;

namespace Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 9, 1,7,2,3,5,10,6 };
            Console.WriteLine(string.Join(",", TwoSum(arr, 11)));
            Console.WriteLine("Hello World!");
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            for(int i =0; i < nums.Length; i++)
            {
                int anotherNumber = target - nums[i];
                if (keyValuePairs.ContainsKey(anotherNumber))
                {
                    return new int[] { keyValuePairs[anotherNumber] , i};
                }

                if (!keyValuePairs.ContainsKey(nums[i]))
                {
                    keyValuePairs.Add(nums[i], i);
                }
            }

            return new int[] { };
        }
    }
}
