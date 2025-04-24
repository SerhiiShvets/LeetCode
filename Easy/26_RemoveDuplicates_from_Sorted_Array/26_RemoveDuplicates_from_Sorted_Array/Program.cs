using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_RemoveDuplicates_from_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int RemoveDuplicates(int[] nums)
            {
                int k = 0;
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[k] != nums[i])
                    {
                        if (i - k > 1)
                        {
                            nums[k + 1] = nums[i];
                        }
                        k++;
                    }
                }
                return k + 1;
            }

            var result = RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
