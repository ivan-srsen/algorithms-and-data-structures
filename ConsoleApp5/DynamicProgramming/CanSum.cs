namespace ConsoleApp5.DynamicProgramming
{
    public class CanSum
    {
        public bool IsSumPossible(int targetSum, int[] numbers)
        {
            if (targetSum < 0)
                return false;

            if (targetSum == 0)
                return true;

            foreach (var number in numbers)
            {
                if (IsSumPossible(targetSum - number, numbers))
                    return true;
            }

            return false;
        }
    }
}
