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
            Mock<Validator> mockValidator = new Mock<Validator>();

            mockValidator.Setup(mv => mv.IsValidMove(position.ToString(), out position)).Returns(true);

            mockPlayer.Setup(mp => mp.Mark).Returns(mark);

            mockBoard.Setup(mb => mb.AddMark(position, mark));

            Game game = new Game(mockBoard.Object, mockValidator.Object, mockPlayer.Object, mockPlayer.Object);

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
