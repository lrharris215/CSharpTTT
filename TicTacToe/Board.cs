using System;
using System.Collections.Generic;
namespace TicTacToe
{
    public class Board
    {

        public List<char> Cells { get; private set; }
        

        public Board()
        {
            
            Cells = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9'};

        }

        public virtual char FindPosition(int position)
        {
            return Cells[position - 1];
        }

        public virtual void AddMark(int position, char mark)
        {
            Cells[position - 1] = mark;
        }
    }
}
