using Xunit;
using AdventOfCode2018;

namespace AdventOfCode2018Tests
{
    public class Day1Tests
    {
        [Fact]
        public void AddNumbersTest()
        {
            Assert.Equal(3, new Day1().AddNumbers(-4, 7));
        }

        [Fact]
        public void SolvePart1Test()
        {
            Assert.Equal(477, new Day1().SolvePart1());
        }
    }
}
