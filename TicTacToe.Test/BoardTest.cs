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

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void IsRowFull_ReturnsTrue_IfAnyRowsHave3OfAKind(int rowNumber)
        {
            Board board = new();

            FillRow(board, rowNumber);
            
            Assert.True(board.IsRowFull());
        }

        [Fact]
        public void IsRowRull_ReturnsFalse_IfNoRowsHave3OfAKind()
        {
            Board board = new();

            Assert.False(board.IsRowFull());
        }

        private void FillRow(IBoard board, int rowNumber)
        {
            if(rowNumber == 1)
            {
                board.AddMark(1, 'X');
                board.AddMark(2, 'X');
                board.AddMark(3, 'X');
            }else if (rowNumber == 2)
            {
                board.AddMark(4, 'X');
                board.AddMark(5, 'X');
                board.AddMark(6, 'X');
            }else if (rowNumber == 3)
            {
                board.AddMark(7, 'X');
                board.AddMark(8, 'X');
                board.AddMark(9, 'X');
            }
        }

    } 
}
