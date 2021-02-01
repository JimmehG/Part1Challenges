using Xunit;

namespace Part1Tests
{
    using Challenge3;
    public class UnitTestChallenge3
    {
        [Theory]
        [InlineData(3, 4, 5, 6)]
        public void GetTriangleArea_CorrectInput_CorrectOutput(int a, int b, int c, float output)
        {
            Assert.Equal(output,Triangle.GetTriangleArea(a, b, c));
        }

        [Theory]
        [InlineData(0, 3, 3)]
        [InlineData(-1, 5, 7)]
        [InlineData(1, 20, 7)]
        public void GetTriangleArea_InvalidTriangle_ThrowsException(int a, int b, int c)
        {
            Assert.Throws<InvalidTriangleException>(() => Triangle.GetTriangleArea(a, b, c));
        }

    }
}
