using System;
using Xunit;

namespace TicTacToe.Test
{
    public class FormatterTest
    {
        [Fact]
        public void FormatBoard_FormatsTheBoard()
        {
            string formattedBoard = @"
             |       |
         1   |   2   |   3
       _____ | _____ | _____
             |       |
         4   |   5   |   6
       _____ | _____ | _____
             |       |
         7   |   8   |   9
             |       |
        "; 
            Board board = new();

            Assert.Equal(formattedBoard, Formatter.FormatBoard(board));
        }
    }
}
