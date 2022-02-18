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
            TestBoard board = new TestBoard();
            TestPlayer player1 = new TestPlayer("P1", 'L');
            TestPlayer player2 = new TestPlayer("P2", 'T');

            Game game = new Game(board, player1, player2);

            //TODO: Figure out a way to mock the receiver, validator

            var input = new StringReader("3");
            Console.SetIn(input);

            var output = new StringWriter();
            Console.SetOut(output);

            game.TakeTurn(player1);

            Assert.Equal(board.FindPosition(3), player1.Mark);

        }
    }

    public class TestBoard : Board
    {
        public override char FindPosition(int position)
        {
            return 'X';
        }

        public override void AddMark(int position, char mark)
        {

        }
    }

    public class TestPlayer : Player
    {
        public override char Mark { get; }

        public TestPlayer(string name, char mark) : base(name, mark)
        {
            Mark = 'Z';
        }
    }

}
