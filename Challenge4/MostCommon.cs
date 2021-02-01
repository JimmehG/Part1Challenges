using System;
using System.Collections.Generic;

namespace Challenge4
{
    public static class MostCommon
    {
        public static int[] GetMostCommon(int[] input)
        {
            var map = new Dictionary<int, int>();
            foreach (var i in input)
            {
                if (map.ContainsKey(i))
                {
                    map[i]++;
                }
                else
                {
                    map.Add(i, 1);
                }
            }

            var bestKeys = new List<int>();
            var bestValue = 0;

            foreach (var pair in map)
            {
                if (pair.Value == bestValue)
                {
                    bestKeys.Add(pair.Key);
                }
                else if (pair.Value > bestValue)
                {
                    bestValue = pair.Value;
                    bestKeys.Clear();
                    bestKeys.Add(pair.Key);
                }
            }

            return bestKeys.ToArray();
        }
    }
}
