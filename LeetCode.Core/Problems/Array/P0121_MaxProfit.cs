namespace LeetCode.Core.Problems.Array
{
    public class P0121_MaxProfit
    {
        public static int MaxProfit(int[] prices)
        {
            var profit = 0;
            var buyPrice = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                var estimatedProfit = prices[i] - buyPrice;

                if (prices[i] < buyPrice)
                {
                    buyPrice = prices[i];
                }

                if(estimatedProfit > profit)
                {
                    profit = estimatedProfit;
                }
            }

            return profit;
        }
    }
}
