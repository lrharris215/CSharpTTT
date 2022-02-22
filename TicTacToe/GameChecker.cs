using System;
namespace TicTacToe
{
    public class GameChecker
    {
        //TODO: add out Player??
        public static bool IsGameWon(IBoard board)
        {
            return IsHorizontalWin(board) || IsVerticalWin(board);
        }

        private static bool IsHorizontalWin(IBoard board)
        {
            return board.IsRowFull();
        }

        private static bool IsVerticalWin(IBoard board)
        {
            return board.IsColumnFull();
        }
    }
}
