using System;

namespace _88_Merge_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var result = Merger.Merge(new int[]{ 1, 2, 3, 0, 0, 0}, 3, new int[]{ 2,5,6}, 3);
            foreach(var el in result)
            {
                Console.WriteLine(el);
            }
            Console.ReadKey();

        }
    }

    public static class Merger
    {
        public static int[] Merge(int[] arr1, int m, int[] arr2, int n)
        {
            int p1 = m - 1;
            int p2 = n - 1;
            int p = m + n - 1;

            while(p1 >= 0 && p2 >= 0)
            {
                if(arr1[p1] > arr2[p2])
                {
                    arr1[p] = arr1[p1];
                    p1--;
                }
                else
                {
                    arr1[p] = arr2[p2];
                    p2--;
                }
                p--;
            }

            while(p2 >= 0)
            {
                arr1[p2] = arr2[p2];
                p2--;
            }

            return arr1;
        }
    }
}
