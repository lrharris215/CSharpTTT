using System;
using System.IO;
using Xunit;

namespace TicTacToe.Test
{
    public class GameTest
    {
        [Fact]
       public void TakeTurn_PlacesAValidMark_OnTheBoard()
        {
            Board board = new();
            Player player1 = new("P1", 'X');
            Player player2 = new("P2", 'O');

            Game game = new Game(board, player1, player2);

            var input = new StringReader("3");
            Console.SetIn(input);

            var output = new StringWriter();
            Console.SetOut(output);

            game.TakeTurn(player1);

            Assert.Equal(board.FindPosition(3), player1.Mark);

        }
    }
}
