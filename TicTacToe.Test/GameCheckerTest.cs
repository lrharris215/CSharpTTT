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
            Assert.False(GameChecker.IsGameWon(board, out _));
        }


        [Fact]
        public void GameChecker_IsGameWon_ReturnsTrue_IfThreeInARow()
        {
           
            board.FillRow();

            Assert.True(GameChecker.IsGameWon(board, out _));
        }

        [Fact]
        public void GameChecker_IsGameWon_OutputsWinner_IfThreeInARow()
        {
            board.FillRow();
            string winnerMark;

            GameChecker.IsGameWon(board, out winnerMark);

            Assert.Equal("X", winnerMark);
            
        }

        [Fact]
        public void GameChecker_IsGameWon_ReturnsTrue_IfThreeInAColumn()
        {

            board.FillCol();

            Assert.True(GameChecker.IsGameWon(board, out _));
        }

        [Fact]
        public void GameChecker_IsGameWon_OutputsWinner_IfThreeInAColumn()
        {
            board.FillCol();
            string winnerMark;

            GameChecker.IsGameWon(board, out winnerMark);

            Assert.Equal("X", winnerMark);

        }

        [Fact]
        public void GameChecker_IsGameWon_ReturnsTrue_IfThreeInADiagonal()
        {
            board.FillDiag();

            Assert.True(GameChecker.IsGameWon(board, out _));
        }

        [Fact]
        public void GameChecker_IsGameWon_OutputsWinner_IfThreeInADiagonal()
        {
            board.FillDiag();
            string winnerMark;

            GameChecker.IsGameWon(board, out winnerMark);

            Assert.Equal("X", winnerMark);

        }

        [Fact]
        public void GameChecker_IsGameWon_OutputsNull_IfNotThreeInAnyDirection()
        {
            string winnerMark;
            GameChecker.IsGameWon(board, out winnerMark);

            Assert.Null(winnerMark);
        }

        [Fact]
        public void GameChecker_IsGameTied_ReturnsTrue_IfGameIsTied()
        {
            board.FillTie();

            Assert.True(GameChecker.IsGameTied(board, out _));
        }

        [Fact]
        public void GameChecker_IsGameTied_OutputsTie_IfGameIsTied()
        {
            board.FillTie();
            string winnerMark;

            GameChecker.IsGameTied(board, out winnerMark);

            Assert.Equal("Tie", winnerMark);

        }

        [Fact]
        public void GameChecker_IsGameTied_ReturnsFalse_IfGameIsNotTied()
        {
            board.FillRow();

            Assert.False(GameChecker.IsGameTied(board, out _));
        }

        [Fact]
        public void GameChecker_IsGameTie_OutputsNull_IfNoTie()
        {
            string winnerMark;
            GameChecker.IsGameTied(board, out winnerMark);

            Assert.Null(winnerMark);
        }

        [Fact]
        public void GameChecker_IsGameWon_ReturnsFalse_IfGameIsNotWon_AndBoardIsFull()
        {
            board.FillTie();
            Assert.False(GameChecker.IsGameWon(board, out _));
        }
    }
}
