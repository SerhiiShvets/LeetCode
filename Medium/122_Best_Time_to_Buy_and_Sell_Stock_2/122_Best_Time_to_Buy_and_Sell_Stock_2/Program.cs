using System;

namespace _122_Best_Time_to_Buy_and_Sell_Stock_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaxProfit(int[] prices)
            {
                var profit = 0;
                
                for(int i = 1; i < prices.Length; i++)
                {
                    if(prices[i] > prices[i - 1])
                    {
                        profit += prices[i] - prices[i - 1];
                    }
                }

                return profit;
            }
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
