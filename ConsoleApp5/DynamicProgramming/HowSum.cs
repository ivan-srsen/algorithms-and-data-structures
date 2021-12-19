using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ConsoleApp5.DynamicProgramming
{
    public class HowSum
    {
        public List<int> Calculate(int targetSum, int[] numbers)
        {
            if (!numbers.Any())
                throw new Exception();

            if (targetSum == 0)
                return new List<int>();

            if (targetSum < 0)
                return null;

            foreach (var number in numbers)
            {
                var result = Calculate(targetSum - number, numbers);

                if (result == null)
                    return null;

                result.Add(number);

                return result;
            }

            return null;
        }
    }
}
