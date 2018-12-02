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
            var mockDay2 = new Mock<Day2>();
            mockDay2.CallBase = true;
            mockDay2.Setup(x => x.ReadFile())
                .Returns(new string[] { "abcdef", "bababc", "abbcde", "abcccd", "aabcdd", "abcdee", "ababab" });

            Assert.Equal(12, mockDay2.Object.SolvePart1());
        }
        

    }
}
