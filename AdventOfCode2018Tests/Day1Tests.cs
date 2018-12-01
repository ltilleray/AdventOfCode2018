using Xunit;
using AdventOfCode2018;
using Moq;

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

        [Fact]
        public void SolvePart2Test()
        {
            Assert.Equal(390, new Day1().SolvePart2());
        }

        [Fact]
        public void IterateOverFrequenciesTest()
        {
            var mockDay1 = new Mock<Day1>();
            mockDay1.CallBase = true;
            mockDay1.Setup(x => x.ReadFile()).Returns(new string[] { "-1", "-2", "2", "3", "7" });

            var result = mockDay1.Object.IterateOverFrequencies(0);
            Assert.Equal(-1, result);
        }

    }
}
