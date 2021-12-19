using System;
using System.Collections.Generic;

namespace ConsoleApp5.DynamicProgramming
{
    public class GridTraveler
    {
        public int CalculatePaths(int m, int n)
        {
            return CalculatePaths(m, n, new Dictionary<string, int>());
        }

        public int CalculatePaths(int m, int n, Dictionary<string, int> memo)
        {
            if (m == 0 || n == 0)
                return 0;

            if (m == 1 || n == 1)
                return 1;

            var min = Math.Min(m, n);
            var max = Math.Max(m, n);

            var key = $"{min},{max}";

            if (memo.ContainsKey(key))
                return memo[key];

            memo[key] = CalculatePaths(m - 1, n, memo) + CalculatePaths(m, n - 1, memo);

            return memo[key];
        }
    }
}
