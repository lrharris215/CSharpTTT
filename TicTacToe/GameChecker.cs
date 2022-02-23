using System;
namespace TicTacToe
{
    public class GameChecker
    {
        public static bool IsGameWon(IBoard board, out string winner)
        {
            return IsHorizontalWin(board, out winner) || IsVerticalWin(board, out winner) || IsDiagonalWin(board, out winner);
        }

        public static bool IsGameTied(IBoard board, out string winner)
        {

            if (board.IsFull() && !IsGameWon(board, out _))
            {
                winner = "Tie";
                return true;
            }else
            {
                winner = null;
                return false;
            }
        }

        private static bool IsHorizontalWin(IBoard board, out string winner)
        {
            return board.IsRowAWinner(out winner);
        }

        private static bool IsVerticalWin(IBoard board, out string winner)
        {
            return board.IsColumnAWinner(out winner);
        }

        private static bool IsDiagonalWin(IBoard board, out string winner)
        {
            return board.IsDiagonalAWinner(out winner);
        }
    }
}
