using System;
using System.Collections.Generic;
namespace TicTacToe
{
    public class Board
    {

        public List<char> Cells { get; }
        

        public Board()
        {
            
            Cells = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9'};

        }

        public char FindPosition(int position)
        {
            return Cells[position - 1];
        }
    }
}
