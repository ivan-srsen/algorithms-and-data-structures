namespace ConsoleApp5.DynamicProgramming
{
    internal class ClimbingStairs
    {
        public int Calculate(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            if (n == 2)
                return 2;

            return Calculate(n - 1) + Calculate(n - 2);
        }
    }
}
