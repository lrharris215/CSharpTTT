using System;
namespace TicTacToe
{
    public class GameChecker
    {
        //TODO: add out Player??
        public static bool IsGameWon(IBoard board)
        {
            return true;
        }

        private static bool IsHorizontalWin(IBoard board)
        {
            return board.IsRowFull();
        }
    }
}
