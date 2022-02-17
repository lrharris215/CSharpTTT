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

        [Theory]
        [InlineData("1")]
        [InlineData("6")]
        [InlineData("9")]
        [InlineData("4")]
        public void IsValidMove_ReturnsTrue_IfInputIs_Between1And9_And_SetsPosition(string input)
        {

            int position;
            bool IsValid = Validator.IsValidMove(input, out position);
            Assert.True(IsValid);
            Assert.Equal(int.Parse(input), position);

        }
    }
}
