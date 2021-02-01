using Xunit;

namespace Part1Tests
{
    using Challenge4;

    public class UnitTestChallenge4
    {
        [Theory]
        [InlineData(new int[] { 5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4 }, new int[] { 5, 4 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 1, 6, 7 }, new int[] { 1 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        [InlineData(new int[] { }, new int[] { })]
        public void GetMostCommon_CorrectInput_CorrectOutput(int[] input, int[] output)
        {
            Assert.Equal(output, MostCommon.GetMostCommon(input));
        }
    }
}
