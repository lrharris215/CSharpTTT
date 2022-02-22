using System;
namespace TicTacToe
{
    public class Game
    {
        private readonly Board Board;
        private readonly Player PlayerOne;
        private readonly Player PlayerTwo;
        private readonly Validator Validator;

        public Player ActivePlayer { get; set; }
        private bool IsGameOver;

        

        public Game(Board board, Validator validator, Player playerOne, Player playerTwo)
        {
            Board = board;
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
            Validator = validator;

            ActivePlayer = PlayerOne;
            IsGameOver = false;
        }

        public void Play()
        {
            Display.Print(Constants.WelcomeMessage);
            
            Display.Print(Formatter.FormatBoard(Board));

            while (!IsGameOver)
            {
                TakeTurn(ActivePlayer);
                SwitchPlayers();
            }
            
        }

        public void TakeTurn(Player player)
        {
            Display.Print(Constants.PlayerTurn(player.Name));
            int position = Receiver.GetPlayerMove(Validator);
            Board.AddMark(position, player.Mark);
            Display.Print(Formatter.FormatBoard(Board));
        }

        public void SwitchPlayers()
        {
            ActivePlayer = ActivePlayer == PlayerOne ? PlayerTwo : PlayerOne;
        }
    }
}
