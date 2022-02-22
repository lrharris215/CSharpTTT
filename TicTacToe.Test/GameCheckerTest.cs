using System;
using Xunit;

namespace TicTacToe.Test
{
    public class GameCheckerTest
    {
        MockBoard board;

        public GameCheckerTest()
        {
            board = new MockBoard();
        }
        [Fact]
        public void GameChecker_IsGameWon_ReturnsFalse_IfBoardIsEmpty()
        { 
            Assert.False(GameChecker.IsGameWon(board));
        }


        [Fact]
        public void GameChecker_IsGameWon_ReturnsTrue_IfThreeInARow()
        {
           
            board.FillRow();

            Assert.True(GameChecker.IsGameWon(board));
        }

        [Fact]
        public void GameChecker_IsGameWon_ReturnsTrue_IfThreeInAColumn()
        {

            board.FillCol();

            Assert.True(GameChecker.IsGameWon(board));
        }

        [Fact]
        public void GameChecker_IsGameWon_ReturnsTrue_IfThreeInADiagonal()
        {
            board.FillDiag();

            Assert.True(GameChecker.IsGameWon(board));
        }

        [Fact]
        public void GameChecker_IsGameTied_ReturnsTrue_IfGameIsTied()
        {
            board.FillTie();

            Assert.True(GameChecker.IsGameTied(board));
        }

        [Fact]
        public void GameChecker_IsGameTied_ReturnsFalse_IfGameIsNotTied()
        {
            board.FillRow();

            Assert.False(GameChecker.IsGameTied(board));
        }

        [Fact]
        public void GameChecker_IsGameWon_ReturnsFalse_IfGameIsNotWon_AndBoardIsFull()
        {
            board.FillTie();
            Assert.False(GameChecker.IsGameWon(board));
        }
    }
}
