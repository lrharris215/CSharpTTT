using System;
using Xunit;

namespace TicTacToe.Test
{
    public class BoardTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void FindPosition_Returns_Cell_Value_At_Given_Position(int value)
        {
            Board b = new Board(3);

            Assert.Equal(b.Cells[value - 1], b.FindPosition(value));
        }

    } 
}
