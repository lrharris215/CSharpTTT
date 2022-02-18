using System;

namespace TicTacToe
{
    public class Validator
    {
        public static bool IsValidMove(string input, out int position)
        {
            return IsValidInput(input, out position) && IsValidPosition(position);
        }

        private static bool IsValidInput(string input, out int position)
        {
            return int.TryParse(input, out position); 
        }

        private static bool IsValidPosition(int position)
        {
            return (position > 0 && position < 10);
        }
    }
}
