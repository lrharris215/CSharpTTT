namespace TicTacToe
{
    public interface IBoard
    {

        char FindPosition(int position);

        void AddMark(int position, char mark);

        bool IsRowAWinner(out string winner);

        bool IsColumnAWinner(out string winner);

        bool IsDiagonalAWinner(out string winner);

        bool IsFull();
    }
}
