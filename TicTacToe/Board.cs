using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class Board : IBoard
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

        public bool IsRowFull()
        {
            List<char> row1 = new List<char> { FindPosition(1), FindPosition(2), FindPosition(3) };
            List<char> row2 = new List<char> { FindPosition(4), FindPosition(5), FindPosition(6) };
            List<char> row3 = new List<char> { FindPosition(7), FindPosition(8), FindPosition(9) };

            List<List<char>> allRows = new List<List<char>> { row1, row2, row3 };

            foreach(List<char> row in allRows)
            {
               if(!row.Any(cell => cell != row[0]))
                {
                    return true;
                }
               
            }

            return false;
            
        }
    }
}
