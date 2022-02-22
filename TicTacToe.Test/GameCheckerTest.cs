using System;
using Xunit;

namespace TicTacToe.Test
{
    public class GameCheckerTest
    {
        [Fact]
        public void GameChecker_IsGameWon_ReturnsFalse_IfBoardIsEmpty()
        {
            IBoard board = new MockBoard();
            Assert.False(GameChecker.IsGameWon(board));
        }


        [Fact]
        public void GameChecker_IsGameWon_ReturnsTrue_IfThreeInARow()
        {
            MockBoard board = new MockBoard();
            board.FillRow();

            Assert.True(GameChecker.IsGameWon(board));
        }

        [Fact]
        public void GameChecker_IsGameWon_ReturnsTrue_IfThreeInAColumn()
        {
            MockBoard board = new MockBoard();
            board.FillCol();

            Assert.True(GameChecker.IsGameWon(board));
        }

        [Fact]
        public void GameChecker_IsGameWon_ReturnsTrue_IfThreeInADiagonal()
        {
            MockBoard board = new MockBoard();
            board.FillDiag();

            Assert.True(GameChecker.IsGameWon(board));
        }
    }
}
