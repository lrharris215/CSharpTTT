using System;
using System.Text.RegularExpressions;

namespace TicTacToe
{
    public class Validator
    {
        public static Board Board { get; set; }
        public static bool IsValidMove(string input, out int position)
        {
            return IsValidInput(input, out position) && IsValidPosition(position) && IsPositionEmpty(position);
        }

        private static bool IsValidInput(string input, out int position)
        {
            return int.TryParse(input, out position); 
        }

        private static bool IsValidPosition(int position)
        {

            return position > 0 && position < 10; 
           
        }

        private static bool IsPositionEmpty(int position)
        {
            Regex numberRegex = new Regex(@"^\d$");
            string boardChar = Board.FindPosition(position).ToString();
            return (numberRegex.IsMatch(boardChar));
        }
    }
}
