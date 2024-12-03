namespace aoc2024.Day02
{
    internal class Q2
    {
        public static int CalculateQ2(List<List<int>> input)
        {
            int count = 0;

            foreach (List<int> report in input)
            {
                if (Q1.CheckSafe(report, dampen: true))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
