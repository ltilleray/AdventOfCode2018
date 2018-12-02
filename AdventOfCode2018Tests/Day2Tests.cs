using Xunit;
using AdventOfCode2018;
using Moq;

namespace AdventOfCode2018Tests
{
    public class Day2Tests
    {

        [Fact]
        public void SolvePart1Test()
        {

            string[] boxIds = new string[] { "abcde", "fghij", "klmno", "pqrst", "fguij", "axcye", "wvxyz" };
            var mockDay2 = new Mock<Day2>();
            mockDay2.CallBase = true;
            mockDay2.Setup(x => x.ReadFile())
                .Returns(new string[] { "abcdef", "bababc", "abbcde", "abcccd", "aabcdd", "abcdee", "ababab" });

            Assert.Equal(12, mockDay2.Object.SolvePart1());
        }

        [Fact]
        public void SolvePart2Test()
        {
            var mockDay2 = new Mock<Day2>();
            mockDay2.CallBase = true;
            mockDay2.Setup(x => x.ReadFile())
                .Returns(new string[] { "abcde", "fghij", "klmno", "pqrst", "fguij", "axcye", "wvxyz" });

            Assert.Equal("fgij", mockDay2.Object.SolvePart2());
        }


    }
}
