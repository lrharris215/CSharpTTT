using System;
namespace TicTacToe
{
    public class Game
    {
        private readonly IBoard Board;
        private readonly Player PlayerOne;
        private readonly Player PlayerTwo;
        private readonly Validator Validator;

        private string winner;

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

            while (!IsGameOver(out winner))
            {
                TakeTurn(ActivePlayer);
                SwitchPlayers();

            }
            EndGame(winner);
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

        public void EndGame(string winnerMark)
        {
            if(winnerMark == "Tie")
            {
                Display.Print(Constants.GameOverTie);
            }
            else
            {
               Player winningPlayer = FindWinner(winnerMark);
               Display.Print(Constants.GameOverWinner(winningPlayer.Name));
            }  
        }

        private bool IsGameOver(out string winner)
        {
            return GameChecker.IsGameTied(Board, out winner) || GameChecker.IsGameWon(Board, out winner);
        }

        private Player FindWinner(string winnerMark)
        {
            if (PlayerOne.Mark.ToString() == winnerMark)
            {
                return PlayerOne;
            }
            else return PlayerTwo;
        }

       
    }
}
