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

        [Fact]
        public void ActivePlayer_DefaultsToPlayerOne_OnGameStart()
        {
            Mock<Board> mockBoard = new Mock<Board>();
            Mock<Player> mockPlayer1 = new Mock<Player>();
            Mock<Player> mockPlayer2 = new Mock<Player>();
            Mock<Validator> mockValidator = new Mock<Validator>();

            Game game = new(mockBoard.Object, mockValidator.Object, mockPlayer1.Object, mockPlayer2.Object);

            Assert.Same(mockPlayer1.Object, game.ActivePlayer);

        }

        [Fact]
        public void SwitchPlayers_ChangesActivePlayer_ToOtherPlayer()
        {
            Mock<Board> mockBoard = new Mock<Board>();
            Mock<Player> mockPlayer1 = new Mock<Player>();
            Mock<Player> mockPlayer2 = new Mock<Player>();
            Mock<Validator> mockValidator = new Mock<Validator>();

            Game game = new(mockBoard.Object, mockValidator.Object, mockPlayer1.Object, mockPlayer2.Object);

            game.SwitchPlayers();

            Assert.Same(mockPlayer2.Object, game.ActivePlayer);

            game.SwitchPlayers();

            Assert.Same(mockPlayer1.Object, game.ActivePlayer);

        }
    }

}
