using System;
using System.Collections;

namespace _169_Majority_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int MajorityElement(int[] nums)
            {
                //Array.Sort(nums);
                //return nums[nums.Length / 2];
                var hashTable = new Hashtable();
                int max = 0;
                int majority = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    if(hashTable.ContainsKey(nums[i]))
                    {
                        var sum = Convert.ToInt32(hashTable[nums[i]]) + 1;
                        hashTable[nums[i]] = sum;
                        if(sum > max)
                        {
                            max = sum;
                            majority = nums[i];
                        }
                    }
                    else
                    {
                        hashTable.Add(nums[i], 1);
                    }
                }
                return majority;
            }

            var result = MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 });
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
