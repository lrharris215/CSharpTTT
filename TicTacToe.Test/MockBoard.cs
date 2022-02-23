using System;
using System.Collections.Generic;

namespace TicTacToe.Test
{
    public class MockBoard : IBoard
    {
        public char Mark;
        public bool HasAddMarkBeenCalled { get; set; }

        public bool Is3InARow;
        public bool Is3InACol;
        public bool Is3InADiag;
        public bool IsBoardFull;

        public MockBoard() 
        {
            Mark = '1';
            HasAddMarkBeenCalled = false;

            Is3InARow = false;
            Is3InACol = false;
            Is3InADiag = false;
            IsBoardFull = false;
            
        }

        public void AddMark(int position, char mark)
        {
            Mark = mark;
            HasAddMarkBeenCalled = true;
        }

        public char FindPosition(int position)
        {
            return Mark;
        }


        public bool IsRowAWinner(out string winner)
        {
            if (Is3InARow)
            {
                winner = "X";
                return true;
            }else
            {
                winner = null;
                return false;
            }
        }

        public bool IsColumnAWinner(out string winner)
        {
            if (Is3InACol)
            {
                winner = "X";
                return true;
            }
            else
            {
                winner = null;
                return false;
            }
        }

        public bool IsDiagonalAWinner(out string winner)
        {
            if (Is3InADiag)
            {
                winner = "X";
                return true;
            }
            else
            {
                winner = null;
                return false;
            }
        }

        public bool IsFull()
        {
            return IsBoardFull;
        }

        internal void FillRow()
        {
            Is3InARow = true;
        }

        internal void FillCol()
        {
            Is3InACol = true;
        }

        internal void FillDiag()
        {
            Is3InADiag = true;
        }

        internal void FillTie()
        {
            IsBoardFull = true;
        }

    }
}
