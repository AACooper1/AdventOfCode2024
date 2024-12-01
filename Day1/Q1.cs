using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1;

internal static class Q1
{

    public static int CalculateQ1((List<int> left, List<int> right) lists)
    {
        return CalculateDistance(SortLists(lists));
    }

    private static (List<int> left, List<int> right) SortLists((List<int> left, List<int> right) lists)
    {
        List<int> left_sorted = lists.left.OrderBy(x => x).ToList();
        List<int> right_sorted = lists.right.OrderBy(x => x).ToList();
        return (left_sorted, right_sorted);
    }

    private static int CalculateDistance((List<int> left, List<int> right) sortedLists)
    {
        List<int> differences = new List<int>();
        for(int i = 0; i < sortedLists.left.Count; i++)
        {
            int difference = sortedLists.left[i] - sortedLists.right[i];
            differences.Add(Math.Abs(difference));
        }

        return differences.Sum();
    }
}
