using System;
namespace TicTacToe
{
    public interface IBoard
    {

        char FindPosition(int position);

        void AddMark(int position, char mark);

        bool IsRowFull();
    }
}
