namespace ConsoleApp5.Trees
{
    public class HammingDistance
    {
        public int CalculateHammingDistance(int x, int y)
        {
            var distance = 0;

            while (x > 0 || y > 0)
            {
                if ((x % 2 != 0 && y % 2 == 0) || (x % 2 == 0 && y % 2 != 0))
                    distance++;

                x >>= 1;
                y >>= 1;
            }

            return distance;
        }
    }
}
