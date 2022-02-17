using System;
using Xunit;
namespace TicTacToe.Test
{
    public class ValidatorTest
    {
        [Theory]
        [InlineData("three")]
        [InlineData("Computer")]
        [InlineData("H")]
        public void IsValidMove_ReturnsFalse_IfInputIs_NAN(string input)
        {
            bool IsValid = Validator.IsValidMove(input, out _);
            Assert.False(IsValid);
        }

        [Theory]
        [InlineData("0")]
        [InlineData("100")]
        [InlineData("23")]
        [InlineData("-4")]
        public void IsValidMove_ReturnsFalse_IfInputIs_LessThan1_OrGreaterThan9(string input)
        {
            bool IsValid = Validator.IsValidMove(input, out _);
            Assert.False(IsValid);
        }
    }
}
