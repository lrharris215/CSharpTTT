using System;
namespace TicTacToe
{
    public class Constants
    {
        public static string InvalidMove = "That is not a valid move! Please enter a number between 1 and 9!\n";

        public static string WelcomeMessage = "\n\n  **  Welcome to Tic Tac Toe!  **\n\n";

        public static string PlayerTurn(string playerName)
        {
            return $"It is {playerName}'s turn! Please enter a number between 1 and 9!\n";
        }

        public static string GameOverTie = "Game over! The game is a tie!\n";

        public static string GameOverWinner(string playerName)
        {
            return $"Congratulations! {playerName} has won the game!\n";
        }

    }
}
