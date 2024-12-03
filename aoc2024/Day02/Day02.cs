namespace aoc2024.Day02;

internal class Solution
{
    private static List<List<int>> ParseInput(string filepath)
    {
        string[] inputText = File.ReadAllLines(filepath);
        List<List<int>> parsedInput = [];
        foreach (string line in inputText)
        {
            List<int> parsedLine = [];
            string[] splitLine = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string entry in splitLine)
            {
                parsedLine.Add(int.Parse(entry));
            }

            parsedInput.Add(parsedLine);
        }

        return parsedInput;
    }
    public static void Run(bool test = false)
    {
        string filepath = test ? "Day02/testInput.txt" : "Day02/input.txt";
        List<List<int>> parsedInput = ParseInput(filepath);

        int Q1Result = Q1.CalculateQ1(parsedInput);
        int Q2Result = Q2.CalculateQ2(parsedInput);

        Console.WriteLine($"Question 1: {Q1Result}");
        Console.WriteLine($"Question 2: {Q2Result}");

        return;
    }
}