using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] target = { 2,1,2,1,0,0,1};
            int result = MaxProfit(target);
        }
        public static int MaxProfit(int[] prices)
        {
            if (prices.Length == 0)
            {
                return 0;
            }
            int max_Profit = 0;
            int current_Price = -1;

            for (int i = 0; i < prices.Length; i++)
            {
                bool isLastDat = i == prices.Length - 1;
                bool tomorrow_Rise = (!isLastDat && prices[i] < prices[i + 1])? true : false;

                if (current_Price == -1)
                {
                    if (tomorrow_Rise)
                    {
                        current_Price = prices[i];
                    }
                }
                else
                {
                    if (prices[i] > current_Price)
                    {
                        if (isLastDat || !tomorrow_Rise)
                        {
                            max_Profit += prices[i] - current_Price;
                            current_Price = -1;
                        }
                    }
                }
            }
            return max_Profit;
        }
    }
}
