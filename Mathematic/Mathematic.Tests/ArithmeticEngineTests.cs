using System;
using FluentAssertions;
using Mathematic.Lib;
using Xunit;

namespace Mathematic.Tests
{
    public class ArithmeticEngineTests
    {
        public ArithmeticEngineTests()
        { 
		}

        [Theory]
        [InlineData(2,3,5)]
        [InlineData(1,2,3)]
        [InlineData(2,2,4)]
        public void Add_Integers_ResultIsCorrect(int num1, int num2, int expected)
        {
            // Arrange
            var arithmeticEngine = new ArithmeticEngine();

            // Act
            var result = arithmeticEngine.Add(num1, num2);

            //Assert
            result.Should().Be(expected);
        }

        [Fact]
        public void Division_ForNum2IsZero_ThrowsDivideByZeroEx()
        {
            // Arrange
            var arithmeticEngine = new ArithmeticEngine();

            // Act
            Action action = () => arithmeticEngine.Division(1, 0);

            //Assert
            action.Should().Throw<DivideByZeroException>();
        }
    }
}
