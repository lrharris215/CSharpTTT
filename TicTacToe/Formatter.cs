using System;
namespace TicTacToe
{
    public class Formatter
    {
        public static string FormatBoard(IBoard board)
        {
            return @$"
             |       |
         {board.FindPosition(1)}   |   {board.FindPosition(2)}   |   {board.FindPosition(3)}
       _____ | _____ | _____
             |       |
         {board.FindPosition(4)}   |   {board.FindPosition(5)}   |   {board.FindPosition(6)}
       _____ | _____ | _____
             |       |
         {board.FindPosition(7)}   |   {board.FindPosition(8)}   |   {board.FindPosition(9)}
             |       |

";
        }
    }
}
