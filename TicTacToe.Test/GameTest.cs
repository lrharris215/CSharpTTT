using System;
using System.IO;
using Moq;
using Xunit;

namespace TicTacToe.Test
{
    public class GameTest
    {
        [Theory]
        [InlineData(3, 'M')]
        [InlineData(4, 'Q')]
        [InlineData(9, 'T')]
        public void TakeTurn_PlacesAValidMark_OnTheBoard(int position, char mark)
        {

            Mock<Board> mockBoard = new Mock<Board>();
            Mock<Player> mockPlayer = new Mock<Player>();

            //For some reason Convert.ToChar() was breaking the test
            char positionChar = position.ToString().ToCharArray()[0];

            //Need to mock different answers: returns the <positionChar> for the validation, then returns <mark> for formatting the board
            mockBoard.SetupSequence(mb => mb.FindPosition(position)).Returns(positionChar).Returns(mark);

            // MockPlayer has the entered mark. 
            mockPlayer.Setup(mp => mp.Mark).Returns(mark);

            // Setting Mock here to verify AddMark has been called
            mockBoard.Setup(mb => mb.AddMark(position, mark));

            Game game = new Game(mockBoard.Object, mockPlayer.Object, mockPlayer.Object);

            var input = new StringReader(position.ToString());
            Console.SetIn(input);

            var output = new StringWriter();
            Console.SetOut(output);

            game.TakeTurn(mockPlayer.Object);

            //Verifies that AddMark has been called once with these arguments
            mockBoard.Verify(mb => mb.AddMark(position, mark), Times.Once());
            

        }
    }

}
