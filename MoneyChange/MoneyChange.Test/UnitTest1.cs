using System;
using Xunit;

namespace MoneyChange.Test
{
    public class UnitTest1
    {
        [Theory]
        //[InlineData(0, 1000, 500, 100, 50, 20, 10, 5, 1)]
        [InlineData(20, 0, 0, 0, 0, 1, 0, 0, 0)]
        [InlineData(30, 0, 0, 0, 0, 1, 1, 0, 0)]
        [InlineData(90, 0, 0, 0, 5, 2, 0, 0, 0)]
        [InlineData(120, 0, 0, 1, 0, 1, 0, 0, 0)]
        [InlineData(300, 0, 0, 3, 0, 0, 0, 0, 0)]
        [InlineData(640, 0, 1, 1, 0, 2, 0, 0, 0)]
        [InlineData(3788, 3, 1, 2, 1, 1, 1, 1, 3)]
        public void Test1(double paidAmount, double expectedThousand, double expectedFiveHundred, double expectedHundred, double expectedFifty, double expectedTwenty, double expectedTen, double expectedFive, double expectedBath)
        {

        }
    }
}
