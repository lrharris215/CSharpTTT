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

        public char FindPosition(int position)
        {
            return Cells[position - 1];
        }

        public void AddMark(int position, char mark)
        {
            Cells[position - 1] = mark;
        }

        public bool IsRowFull()
        {

            List<List<char>> allRows = FindRows();

            foreach(List<char> row in allRows)
            {
               if(!row.Any(cell => cell != row[0]))
                {
                    return true;
                }
               
            }

            return false;
            
        }

        public bool IsColumnFull()
        {
            List<List<char>> allColumns = FindCols();
            foreach(List<char> column in allColumns)
            {
                if(!column.Any(cell => cell!= column[0]))
                {
                    return true;
                }
            }
            return false;
        }

        private List<List<char>> FindRows()
        {
            List<char> row1 = new() { FindPosition(1), FindPosition(2), FindPosition(3) };
            List<char> row2 = new() { FindPosition(4), FindPosition(5), FindPosition(6) };
            List<char> row3 = new() { FindPosition(7), FindPosition(8), FindPosition(9) };

            return new List<List<char>> { row1, row2, row3 };
        }

        private List<List<char>> FindCols()
        {
            List<char> col1 = new() { FindPosition(1), FindPosition(4), FindPosition(7) };
            List<char> col2 = new() { FindPosition(2), FindPosition(5), FindPosition(8) };
            List<char> col3 = new() { FindPosition(3), FindPosition(6), FindPosition(9) };

            return new List<List<char>> { col1, col2, col3 };
        }
    }
}
