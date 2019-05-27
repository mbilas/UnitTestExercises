using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Mathematic.Lib;
using NSubstitute;
using Xunit;

namespace Mathematic.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void CircumferenceOfRectangle_Integers_ResultIsCorrect()
        {
            // Arrange
            var arithmeticEngine = Substitute.For<IArithmeticEngine>();
            var calculator = new Calculator(arithmeticEngine);

            arithmeticEngine.Add(2, 3).Returns(5);
            arithmeticEngine.Multiply(2, 5).Returns(10);

            // Act
            var result = calculator.CircumferenceOfRectangle(2, 3);

            // Assert
            result.Should().Be(10);
        }
    }    
}
