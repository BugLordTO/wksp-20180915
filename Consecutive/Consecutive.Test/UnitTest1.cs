using System;
using Xunit;

namespace Consecutive.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(27, new int[] { 13, 14 })]
        [InlineData(44, new int[] { 2, 3, 4, 5, 6, 7, 8, 9 })]
        public void Test1(int input, int[] expectedResults)
        {
            var engine = new ConsecutiveEngine();
            var results = engine.Process(input);
            Assert.Equal(expectedResults, results);
        }
    }
}
