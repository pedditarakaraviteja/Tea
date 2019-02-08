using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
    }
    public class Calculator
    {
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }
    }
    public class CalculatorTests
    {
        [Fact]
        public void weAdd()
        {
            var calculator = new Calculator();

            int value1 = 1;
            int value2 = 2;

            var result = calculator.Add(value1, value2);

            Assert.Equal(3, result);
        }



        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2, 2, 0)]
     
        public void CanWeAdd(int value1, int value2, int expected)
        {
            var calculator = new Calculator();

            var result = calculator.Add(value1, value2);

            Assert.Equal(expected, result);
        }
    }
}


