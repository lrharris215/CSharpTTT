using System;
namespace TicTacToe
{
    public class Receiver
    {

       public static int GetPlayerMove()
        {
            string input = GetInput();
            int position;
            while (!Validator.IsValidMove(input, out position))
            {
                Display.PrintError(Constants.InvalidMove);
                input = GetInput();
            }
            return position;
        }

       public static string GetInput()
        {
            return Console.ReadLine();
        }
    }
}
