using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Board board = new Board(3);

            Display.Print(Formatter.FormatBoard(board));
        }
    }
}
