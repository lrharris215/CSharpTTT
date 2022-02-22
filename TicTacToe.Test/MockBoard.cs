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

        public MockBoard() 
        {
            Mark = '1';
            HasAddMarkBeenCalled = false;

            Is3InARow = false;
            Is3InACol = false;
            Is3InADiag = false;
            
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


        public bool IsRowAWinner()
        {
            return Is3InARow;
        }

        public bool IsColumnAWinner()
        {
            return Is3InACol;
        }

        public bool IsDiagonalAWinner()
        {
            return Is3InADiag;
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

    }
}
