using System;
namespace TicTacToe
{
    public class Game
    {
        Board Board;
        Player PlayerOne;
        Player PlayerTwo;
        Validator Validator;
        

        public Game(Board board, Validator validator, Player playerOne, Player playerTwo)
        {
            Board = board;
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
            Validator = validator;
        }

        public void Play()
        {
            Display.Print(Constants.WelcomeMessage);
            
            Display.Print(Formatter.FormatBoard(Board));

            TakeTurn(PlayerOne);
            TakeTurn(PlayerTwo);
        }

        public void TakeTurn(Player player)
        {
            Display.Print(Constants.PlayerTurn(player.Name));
            int position = Receiver.GetPlayerMove(Validator);
            Board.AddMark(position, player.Mark);
            Display.Print(Formatter.FormatBoard(Board));
        }
    }
}
