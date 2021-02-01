using Xunit;

namespace Part1Tests
{
    using Challenge2;
    using System;

    public class UnitTestChallenge2
    {
        [Theory]
        [InlineData(60, new int[] { 1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60 })]
        [InlineData(42, new int[] { 1, 2, 3, 6, 7, 14, 21, 42 })]
        public void PositiveDivisors_PositiveInput_CorrectOutput(int input, int[] expected)
        {
            Assert.Equal(expected, PositiveDivisors.GetPositiveDivisors(input));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void PositiveDivisors_0orNegativeInput_ThrowsException(int input)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => PositiveDivisors.GetPositiveDivisors(input));
        }
    }
}
