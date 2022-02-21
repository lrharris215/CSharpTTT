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

            Mock<Board> mockBoard = new Mock<Board>();
            Mock<Player> mockPlayer = new Mock<Player>();
           
            //Need to mock different answers: returns 3 for the validation, then returns M for formatting the board
            mockBoard.SetupSequence(mb => mb.FindPosition(3)).Returns('3').Returns('M');

            // MockPlayer has mark M
            mockPlayer.Setup(mp => mp.Mark).Returns('M');

            // Setting Mock here to verify AddMark has been called
            mockBoard.Setup(mb => mb.AddMark(3, 'M'));

            Game game = new Game(mockBoard.Object, mockPlayer.Object, mockPlayer.Object);

            var input = new StringReader("3");
            Console.SetIn(input);

            var output = new StringWriter();
            Console.SetOut(output);

            game.TakeTurn(mockPlayer.Object);

            //Verify's AddMark has been called once with these arguments
            mockBoard.Verify(mb => mb.AddMark(3, 'M'), Times.Once());
            

        }
    }

}
