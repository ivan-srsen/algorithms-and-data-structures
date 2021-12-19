using System;
using System.Collections.Generic;

namespace ConsoleApp5.DynamicProgramming
{
    public class Fibonacci
    {
        public int GetFib(int n)
        {
            var dict = new Dictionary<int, int>();
            return GetFib(n, dict);
        }

        private int GetFib(int n, Dictionary<int, int> memo)
        {
            if (n == 1 || n == 2)
                return 1;

            if (memo.ContainsKey(n))
                return memo[n];

            var result = GetFib(n - 1, memo) + GetFib(n - 2, memo);

            memo[n] = result;

            return result;
        }
    }
}
