using System;
namespace TicTacToe
{
    public class Display
    {

        public static void Print(string input)
        {
            Console.Write(input);
        }

        public static void PrintError(string input)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(input);
            Console.ResetColor();
        }

    }
}
