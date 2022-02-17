using System;

namespace TicTacToe
{
    public class Validator
    {
        public static bool IsValidMove(string input, out int position)
        {
            bool isValid = int.TryParse(input, out position);

            if (!isValid)
            {
                Display.Print("That is not a valid input! Please enter a number between 1 and 9!\n");
            }

            return isValid;
        }
    }
}
