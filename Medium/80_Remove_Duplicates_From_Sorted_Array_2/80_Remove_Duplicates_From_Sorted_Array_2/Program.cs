using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80_Remove_Duplicates_From_Sorted_Array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int RemoveDuplicates(int[] nums)
            {
                if (nums.Length < 3) return nums.Length;

                int k = 2;
                for (int i = 2; i < nums.Length; i++)
                {
                    if (nums[i] != nums[k - 2])
                    {
                        nums[k] = nums[i];
                        k++;
                    }
                }
                return k;
            }

            var result = RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 });
        }
    }
}
