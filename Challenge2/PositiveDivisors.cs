using System;
using System.Collections.Generic;

namespace Challenge2
{
    public static class PositiveDivisors
    {
        public static int[] GetPositiveDivisors(int input)
        {
            if (input <= 0)
            {
                throw new ArgumentOutOfRangeException("Paramater must be positive");
            }

            var ret = new List<int>();

            for (int i = 1; i <= Math.Sqrt(input); i++)
            {
                if (input % i == 0)
                {
                    ret.Add(i);
                    if (i != input / i)
                    {
                        ret.Add(input / i);
                    }
                }
            }
            ret.Sort();
            return ret.ToArray();

        }
    }
}
