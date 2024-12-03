using System.Text.RegularExpressions;

namespace aoc2024.Day03
{
    // I mean strictly speaking I really don't need this class to exist at all, but .
    internal class Q2
    {
        public static int CalculateQ2(string input)
        {
            return Q1.FindProduct(input, conditionals: true);
        }
    }
}
