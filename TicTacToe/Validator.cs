using System;
using System.Text.RegularExpressions;

namespace TicTacToe
{
    public class Validator
    {
        public Board Board { get; set; }

        public Validator(Board board)
        {
            Board = board;
        }

        public Validator() { }

        public virtual bool IsValidMove(string input, out int position)
        {
            return IsValidInput(input, out position) && IsValidPosition(position) && IsPositionEmpty(position);
        }

        private bool IsValidInput(string input, out int position)
        {
            return int.TryParse(input, out position); 
        }

        private bool IsValidPosition(int position)
        {

            return position > 0 && position < 10; 
           
        }

        private bool IsPositionEmpty(int position)
        {
            Regex numberRegex = new Regex(@"^\d$");
            string boardChar = Board.FindPosition(position).ToString();
            return (numberRegex.IsMatch(boardChar));
        }
    }
}
