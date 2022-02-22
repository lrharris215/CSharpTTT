using System;
namespace TicTacToe
{
    public class Game
    {
        private readonly IBoard Board;
        private readonly Player PlayerOne;
        private readonly Player PlayerTwo;
        private readonly Validator Validator;

        public Player ActivePlayer { get; set; }


        public Game(IBoard board, Validator validator, Player playerOne, Player playerTwo)
        {
            Board = board;
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
            Validator = validator;

            ActivePlayer = PlayerOne;
            
        }

        public void Play()
        {
            Display.Print(Constants.WelcomeMessage);
            
            Display.Print(Formatter.FormatBoard(Board));

            while (!IsGameOver())
            {
                TakeTurn(ActivePlayer);
                SwitchPlayers();

            }
            EndGame();
            //Console.WriteLine("woof?");
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

        public void EndGame()
        {
            SwitchPlayers();
            Display.Print($"Congratulations! {ActivePlayer.Name} has won the game!\n");
        }

        private bool IsGameOver()
        {
            return GameChecker.IsGameWon(Board);
        }

       
    }
}
