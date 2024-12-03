namespace aoc2024.Day03;

internal class Solution
{
    public static void Run(bool test = false)
    {
        string filepath = test ? "Day03/testInput.txt" : "Day03/input.txt";
        string input = File.ReadAllText(filepath);

        //int Q1Result = Q1.CalculateQ1(input);
        int Q2Result = Q2.CalculateQ2(input);

        //Console.WriteLine($"Question 1: {Q1Result}");
        Console.WriteLine($"Question 2: {Q2Result}");

        return;
    }
}
