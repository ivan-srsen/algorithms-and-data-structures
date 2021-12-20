namespace ConsoleApp5.DynamicProgramming
{
    internal class CoinChange
    {
        public int Change(int[] coins, int sum)
        {
            if (sum < 0)
                return -1;

            if (sum == 0)
                return 1;

            var bestResult = 0;

            foreach(var coin in coins)
            {
                var result = Change(coins, sum - coin);

                if (result < 0)
                    continue;

                if(result < bestResult)
                    bestResult = result;
            }

            if (bestResult > 0)
                return bestResult + 1;

            return -1;
        }
    }
}
