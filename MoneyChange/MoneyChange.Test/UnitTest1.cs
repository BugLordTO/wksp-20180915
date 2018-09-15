using System;
using Xunit;

namespace MoneyChange.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(20, 15, 5)]
        [InlineData(200, 115, 85)]
        [InlineData(2015, 515, 1500)]
        [InlineData(213, 175, 38)]
        public void Test1(double input, double price, double expectedChange)
        {
            var engine = new MoneyChangeEngine();
            var result = engine.Calculate1(input, price);
            Assert.Equal(expectedChange, result);
        }

        [Theory]
        //[InlineData(0, 1000, 500, 100, 50, 20, 10, 5, 1)]
        [InlineData(20, new int[] { 0, 0, 0, 0, 1, 0, 0, 0 })]
        [InlineData(30, new int[] { 0, 0, 0, 0, 1, 1, 0, 0 })]
        [InlineData(90, new int[] { 0, 0, 0, 1, 2, 0, 0, 0 })]
        [InlineData(120, new int[] { 0, 0, 1, 0, 1, 0, 0, 0 })]
        [InlineData(300, new int[] { 0, 0, 3, 0, 0, 0, 0, 0 })]
        [InlineData(640, new int[] { 0, 1, 1, 0, 2, 0, 0, 0 })]
        [InlineData(3788, new int[] { 3, 1, 2, 1, 1, 1, 1, 3 })]
        public void Test2(double change, int[] expectedResults)
        {
            var engine = new MoneyChangeEngine();
            var results = engine.Calculate2(change);
            Assert.Equal(expectedResults, results);
        }
    }
}
