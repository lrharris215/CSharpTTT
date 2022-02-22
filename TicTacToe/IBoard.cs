namespace TicTacToe
{
    public interface IBoard
    {

        char FindPosition(int position);

        void AddMark(int position, char mark);

        bool IsRowAWinner();

        bool IsColumnAWinner();

        bool IsDiagonalAWinner();
    }
}
