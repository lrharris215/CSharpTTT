using System;
namespace TicTacToe.Test
{
    public class MockBoard : IBoard
    {
      public char mark;
      public bool HasAddMarkBeenCalled { get; set; }

        public MockBoard() 
        {
            mark = '1';
            HasAddMarkBeenCalled = false;
        }

        public void AddMark(int position, char mark)
        {
            this.mark = mark;
            HasAddMarkBeenCalled = true;
        }

        public char FindPosition(int position)
        {
            return mark;
        }
    }
}
