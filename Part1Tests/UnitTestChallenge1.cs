using Xunit;

namespace Part1Tests
{
    using Challenge1;
    public class UnitTestChallenge1
    {
        [Fact]
        public void IsNullOrEmpty_NullInput_TrueOutput()
        {
            string input = null;
            Assert.True(input.IsNullOrEmpty());
        }
        [Fact]
        public void IsNullOrEmpty_StringInput_FalseOutput()
        {
            string input = "a";
            Assert.False(input.IsNullOrEmpty());
        }
        [Fact]
        public void IsNullOrEmpty_EmptyStringInput_TrueOutput()
        {
            string input = "";
            Assert.True(input.IsNullOrEmpty());
        }
        [Fact]
        public void IsNullOrEmpty_StringAsNullInput_FalseOutput()
        {
            string input = "null";
            Assert.False(input.IsNullOrEmpty());
        }
    }
}
