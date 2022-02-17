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
            bool IsValid = false;
            int position;

            do
            {
                string input = Receiver.GetInput();
                
                IsValid = Validator.IsValidMove(input, out position);

                //TODO: Error handling
                
            } while (!IsValid);


            Board.AddMark(position, player.Mark);
            Display.Print(Formatter.FormatBoard(Board));
        }
    }
}
