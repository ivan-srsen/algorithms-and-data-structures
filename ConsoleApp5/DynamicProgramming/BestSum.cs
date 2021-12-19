using System.Collections.Generic;

namespace ConsoleApp5.DynamicProgramming
{
    public class BestSum
    {
        public List<int> Calculate(int targetSum, int[] numbers)
        {
            if (targetSum == 0)
                return new List<int>();

            if (targetSum < 0)
                return null;

            List<int> bestResult = null;

            foreach (var number in numbers)
            {
                var result = Calculate(targetSum - number, numbers);

                if (result != null)
                {
                    if (bestResult == null || (bestResult.Count < result.Count))
                        bestResult = result;
                }
            }

            return bestResult;
        }
    }
}
