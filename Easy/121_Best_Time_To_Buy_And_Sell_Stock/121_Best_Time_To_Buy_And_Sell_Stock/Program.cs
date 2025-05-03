using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _121_Best_Time_To_Buy_And_Sell_Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaxProfit(int[] prices)
            {
                int l = 0;
                int r = 1;
                int maxProfit = 0;

                while (r < prices.Length)
                {
                    if (prices[l] < prices[r])
                    {
                        int profit = prices[r] - prices[l];
                        maxProfit = profit > maxProfit ? profit : maxProfit;
                        r++;
                    }
                    else
                    {
                        l = r;
                        r++;
                    }
                }
                return maxProfit;
            }
            var result = MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });

            Console.ReadKey();
        }
    }
}
