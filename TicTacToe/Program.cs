using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Display.Print(Constants.WelcomeMessage);
            Board board = new();

            Display.Print(Formatter.FormatBoard(board));
        }
    }
}
