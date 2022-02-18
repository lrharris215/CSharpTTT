using System;
using System.IO;
using Moq;
using Xunit;

namespace TicTacToe.Test
{
    public class GameTest
    {
        [Fact]
        public void TakeTurn_PlacesAValidMark_OnTheBoard()
        {

            var mockBoard = Mock.Of<Board>();
            var mockPlayer = Mock.Of<Player>();

            Mock.Get(mockBoard).SetupSequence(mb => mb.FindPosition(3)).Returns('3').Returns('M').Returns('M');
            
            Mock.Get(mockPlayer).Setup(mp => mp.Mark).Returns('M');

            Game game = new Game(mockBoard, mockPlayer, mockPlayer);

            var input = new StringReader("3");
            Console.SetIn(input);

            var output = new StringWriter();
            Console.SetOut(output);

            game.TakeTurn(mockPlayer);

            Assert.Equal(mockPlayer.Mark, mockBoard.FindPosition(3));

        }
    }

}
