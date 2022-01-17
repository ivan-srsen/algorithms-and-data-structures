using System;

namespace ConsoleApp5.DynamicProgramming
{
    internal class HouseRobber
    {
        public int Rob(int[] amounts)
        {

        }

        private int RobDynammic(int[] amounts, int position)
        {
            if (position == amounts.Length - 3)
                return amounts[amounts.Length - 1];

            if (position == amounts.Length - 2)
                return 0;

            var firstChoice = amounts[position] + RobDynammic(amounts, position + 2);
            var secondChoice = amounts[position + 1] + RobDynammic(amounts, position + 3);

            return Math.Max(firstChoice, secondChoice);
        }
    }
}
