using System;
using Xunit;
using AdventOfCode2018;

namespace AdventOfCode2018Tests
{
    public class HelloWorldTests
    {
        [Fact]
        public void HelloWorldStringTest()
        {
            HelloWorld helloWorld = new HelloWorld();
            Assert.True(helloWorld.HelloWorldString() == "HelloWorld");
        }
    }
}
