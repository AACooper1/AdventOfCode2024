using System;
namespace Day1;

class InputParser
{
    public static (List<int> left, List<int> right) ParseInput(string filepath)
    {
        String[] input_text = File.ReadAllLines(filepath);
        List<int> left  = new List<int>();
        List<int> right = new List<int>();

        foreach (String line in input_text)
        {
            String[] splitLine = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            try
            {
                left.Add(int.Parse(splitLine[0]));
                right.Add(int.Parse(splitLine[1]));
            }
            catch
            {
                throw;
            }
        }

        return (left, right);
    }
}
class Program
{
    static void Main()
    {
        String filepath = "input.txt";
        (List<int> left, List<int> right) parsedInput = InputParser.ParseInput(filepath);

        int Q1Result = Q1.CalculateQ1(parsedInput);
        int Q2Result = Q2.CalculateQ2(parsedInput);

        Console.WriteLine($"Question 1: {Q1Result}");
        Console.WriteLine($"Question 2: {Q2Result}");

        return;
    }
}