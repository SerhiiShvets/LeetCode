using System;


namespace _27_Remove_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var array = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            var result = solution.RemoveElement(array, 2);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int leftPointer = 0;

            for (int rightPointer = 0; rightPointer < nums.Length; rightPointer++)
            {
                if (nums[rightPointer] != val)
                {
                    nums[leftPointer] = nums[rightPointer];
                    leftPointer++;
                }
            }

            return leftPointer;
        }
    }
}
