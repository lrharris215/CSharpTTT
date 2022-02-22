using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Player playerOne = new Player("Player One", 'X');
            Player playerTwo = new Player("Player Two", 'O');
            Validator validator = new Validator(board);
            Game game = new Game(board, validator, playerOne, playerTwo);

            game.Play();
        }
    }
}
