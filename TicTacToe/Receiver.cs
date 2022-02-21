using System;
namespace TicTacToe
{
    public class Receiver
    {
       
       public static int GetPlayerMove(Validator validator)
        {
            string input = GetInput();
            int position;
            while (!validator.IsValidMove(input, out position))
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
