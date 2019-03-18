using System;
using Xunit;
using CalculatorWithXUnit;

namespace Test
{
    public class ProgramTest
    {
        [Fact]
        public void CalculatorWithXUnit_Add()
        {
            Assert.Equal(4, Program.Add(2, 2));
        }

        [Fact]
        public void CalculatorWithXUnit_Subtract()
        {
            Assert.Equal(2, Program.Subtract(4, 2));
        }

        [Fact]
        public void CalculatorWithXUnit_Multiply()
        {
            Assert.Equal(8, Program.Multiply(4, 2));
        }

        [Fact]
        public void CalculatorWithXUnit_Divide()
        {
            Assert.Equal(4, Program.Divide(8, 2));
        }
    }
}
