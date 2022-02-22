using System;
using Xunit;

namespace TicTacToe.Test
{
    public class GameCheckerTest
    {
        [Fact]
        public void GameChecker_IsGameWon_ReturnsTrue_IfThreeInARow()
        {
            MockBoard board = new MockBoard();
            board.FillRow();

            Assert.True(GameChecker.IsGameWon(board));
        }
    }
}
