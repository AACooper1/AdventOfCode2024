namespace aoc2024.Day02;

internal static class Q1
{
    public static bool CheckSafe(List<int> input, bool dampen = false)
    {
        bool ascending = false;
        bool descending = false;
        bool safe = true;
        int violation_idx = 0;
        for(int i = 1; i < input.Count; i++)
        {
            switch (input[i] - input[i-1])
            {
                case > 3 or < -3:
                    safe = false;
                    break;
                case 0: 
                    safe = false;
                    break;
                case < 0: 
                    descending = true; 
                    break;

                case > 0:
                    ascending = true;
                    break;
            }
            if (ascending && descending)
            {
                safe = false;
            }

            if (!safe)
            {
                violation_idx = i;
                break;
            }
        }

        // Just a single check (with a special case for i=1) should do
        if (!safe && dampen)
        {
            List<int> inputCopy = new(input);
            inputCopy.RemoveAt(violation_idx);

            if (CheckSafe(inputCopy, dampen: false))
            {
                safe = true;
            }
            else 
            {
                inputCopy = new(input);
                inputCopy.RemoveAt(violation_idx - 1);

                if (CheckSafe(inputCopy, dampen: false))
                {
                    safe = true;
                }
                else if (CheckSafe(input[1..], dampen: false))
                {
                    safe = true;
                }
                else { }
            }
        }

            return safe;
    }

    public static int CalculateQ1(List<List<int>> input)
    {
        int count = 0;

        foreach(List<int> report in input)
        {
            if(CheckSafe(report))
            {
                count++;
            }
        }

        return count;
    }
}
