using System;

namespace Challenge3
{
    public static class Triangle
    {
        public static double GetTriangleArea(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new InvalidTriangleException("One or more lengths of the triangle are zero or negative");
            }
            if (!(a < b + c && b < a + c && c < a + b))
            {
                throw new InvalidTriangleException("Inputs cannot form a triangle");
            }
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}
