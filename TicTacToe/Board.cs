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

        public bool IsRowAWinner()
        {

            List<List<char>> allRows = FindRows();

            return IsThreeOfAKind(allRows);
            
        }

        public bool IsColumnAWinner()
        {
            List<List<char>> allColumns = FindCols();
            return IsThreeOfAKind(allColumns);
        }


        public bool IsDiagonalAWinner()
        {
            List<List<char>> allDiagonals = FindDiagonals();
            return IsThreeOfAKind(allDiagonals);
        }

        public bool IsFull()
        {
            if(Cells.All(cell => cell == 'X' || cell == 'O'))
            {
                return true;
            }
            return false;
        }

        private bool IsThreeOfAKind(List<List<char>> cellSets)
        {
            foreach(List<char> cellSet in cellSets)
            {
                if(!cellSet.Any(cell => cell!= cellSet[0]))
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

        private List<List<char>> FindDiagonals()
        {
            List<char> col1 = new() { FindPosition(1), FindPosition(5), FindPosition(9) };
            List<char> col2 = new() { FindPosition(3), FindPosition(5), FindPosition(7) };

            return new List<List<char>> { col1, col2 };
        }

    }
}
