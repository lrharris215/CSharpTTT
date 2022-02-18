using System;
namespace TicTacToe
{
    public class Game
    {
        Board Board;
        Player PlayerOne;
        

        public Game(Board board, Player playerOne)
        {
            Board = board;
            PlayerOne = playerOne;
        }

        public void Play()
        {
            Display.Print(Constants.WelcomeMessage);
            
            Display.Print(Formatter.FormatBoard(Board));

            TakeTurn(PlayerOne);
        }

        public void TakeTurn(Player player)
        {
            Display.Print(Constants.PlayerTurn(player.Name));
            int position = Receiver.GetPlayerMove();
            Board.AddMark(position, player.Mark);
            Display.Print(Formatter.FormatBoard(Board));
        }
    }
}
