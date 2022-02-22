using System;
namespace TicTacToe
{
    public class GameChecker
    {
        //TODO: add out Player??
        public static bool IsGameWon(IBoard board)
        {
            return IsHorizontalWin(board) || IsVerticalWin(board) || IsDiagonalWin(board);
        }

        public static bool IsGameTied(IBoard board)
        {
            return board.IsFull() && !IsGameWon(board);
        }

        private static bool IsHorizontalWin(IBoard board)
        {
            return board.IsRowAWinner();
        }

        private static bool IsVerticalWin(IBoard board)
        {
            return board.IsColumnAWinner();
        }

        private static bool IsDiagonalWin(IBoard board)
        {
            return board.IsDiagonalAWinner();
        }
    }
}
