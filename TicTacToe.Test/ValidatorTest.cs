using System;
using Moq;
using Xunit;

namespace TicTacToe.Test
{
    public class ValidatorTest
    {
        // Fixtures are set in the Constructor. A new ValidatorTest is created everytime a test is run.
       
        Validator validator;
        MockBoard mockBoard;


        public ValidatorTest()
        {
            mockBoard = new MockBoard();
            validator = new Validator(mockBoard);
        }

        [Theory]
        [InlineData("three")]
        [InlineData("Computer")]
        [InlineData("H")]
        public void IsValidMove_ReturnsFalse_IfInputIs_NAN(string input)
        {

            bool isValid = validator.IsValidMove(input, out _);
            Assert.False(isValid);
        }

        [Theory]
        [InlineData("0")]
        [InlineData("100")]
        [InlineData("23")]
        [InlineData("-4")]
        public void IsValidMove_ReturnsFalse_IfInputIs_LessThan1_OrGreaterThan9(string input)
        {

            bool isValid = validator.IsValidMove(input, out _);
            Assert.False(isValid);
        }

        [Theory]
        [InlineData("1")]
        [InlineData("6")]
        [InlineData("9")]
        [InlineData("4")]
        public void IsValidMove_ReturnsTrue_IfInputIs_Between1And9_And_SetsPosition(string input)
        {

           
            int position;
            bool isValid = validator.IsValidMove(input, out position);
            Assert.True(isValid);
            Assert.Equal(int.Parse(input), position);

        }

        [Fact]
        public void IsValidMove_ReturnsFalse_IfSpaceIsAlreadyTaken()
        {

            int position = 5;
            validator.Board.AddMark(position, 'T');

            bool isValid = validator.IsValidMove(position.ToString(), out _);

            Assert.False(isValid);

        }
    }
}
