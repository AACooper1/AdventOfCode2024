using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal static class Q2
    {
        public static int CalculateQ2((List<int> left, List<int> right) lists)
        {
            Dictionary<int, int> counts = [];

            foreach(int entry in lists.right)
            {
                int count = 0;
                counts.TryGetValue(entry, out count);
                
                counts[entry] = ++count;
            }

            int sum = 0;

            foreach(int entry in lists.left)
            {
                int factor = 0;
                counts.TryGetValue(entry, out factor);
                sum += entry * factor;
            }

            return sum;
        }
    }
}
