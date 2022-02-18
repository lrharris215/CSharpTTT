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
            Board board = new();

            Assert.Equal(board.Cells[value - 1], board.FindPosition(value));
        }

        [Theory]
        [InlineData(1, 'X')]
        [InlineData(6, 'O')]
        public void AddMark_Places_Mark_on_Specified_Cell(int position, char mark)
        {
            Board board = new();

            board.AddMark(position, mark);

            Assert.Equal(board.FindPosition(position), mark);
        }

    } 
}
