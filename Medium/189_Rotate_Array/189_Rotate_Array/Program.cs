using System;

namespace _189_Rotate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            void RotateArray(int[] nums, int k)
            {
                k = k % nums.Length;
                Reverse(nums, 0, nums.Length - 1);
                Reverse(nums, 0, k - 1);
                Reverse(nums, k, nums.Length - 1);
            }
            void Reverse(int[] nums, int start, int end)
            {
                while(start < end)
                {
                    int temp = nums[start];
                    nums[start] = nums[end];
                    nums[end] = temp;
                    start++;
                    end--;
                }
            }
            //RotateArray(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3);
            //RotateArray(new int[] { 1 }, 2);
            Console.WriteLine(5 % 4);   // output: 1
            Console.WriteLine(5 % -4);  // output: 1
            Console.WriteLine(-5 % 4);  // output: -1
            Console.WriteLine(-5 % -4); // output: -1
            Console.WriteLine(2 % 10); // output: 2

            Console.ReadKey();
        }
    }
}
