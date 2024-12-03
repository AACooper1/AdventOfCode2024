using System.Text.RegularExpressions;

namespace aoc2024.Day03
{
    internal class Q1
    {
        public static int FindProduct(string input, bool conditionals = false)
        {
            string pattern = @"(mul\(\d{1,3},\d{1,3}\))";
            if (conditionals)
            {
                pattern += @"|(do\(\))|(don't\(\))";
            }

            MatchCollection matches = Regex.Matches(input, pattern);
            int sum = 0;
            bool enable = true;

            foreach(Match m in matches)
            {
                string match = m.ToString();

                if (match.StartsWith('d'))
                {
                    enable = !Regex.IsMatch(match, @"'");
                    continue;
                }

                if (!enable)
                {
                    continue;
                }

                int product = 1;
                MatchCollection factors = Regex.Matches(match, @"\d{1,3}");
                
                foreach (Match f in factors)
                {
                    int factor = int.Parse(f.ToString());
                    product *= factor;
                }

                sum += product;
            }
            return sum;
        }

        public static int CalculateQ1(string input)
        {
            return FindProduct(input, conditionals: false);
        }
    }
}
