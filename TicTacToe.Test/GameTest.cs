using System;
using System.IO;
using Moq;
using Xunit;

namespace TicTacToe.Test
{
    public class GameTest
    {
        MockBoard mockBoard;
        Mock<Player> mockPlayer1;
        Mock<Player> mockPlayer2;
        Mock<Validator> mockValidator;

        Game game;

        public GameTest()
        {
            mockBoard = new MockBoard();
            mockPlayer1 = new Mock<Player>();
            mockPlayer2 = new Mock<Player>();
            mockValidator = new Mock<Validator>();

            game = new Game(mockBoard, mockValidator.Object, mockPlayer1.Object, mockPlayer2.Object);
        }

        [Theory]
        [InlineData(3, 'M')]
        [InlineData(4, 'Q')]
        [InlineData(9, 'T')]
        public void TakeTurn_PlacesAValidMark_OnTheBoard(int position, char mark)
        {
 
            mockValidator.Setup(mv => mv.IsValidMove(position.ToString(), out position)).Returns(true);

            mockPlayer1.Setup(mp => mp.Mark).Returns(mark);

            var input = new StringReader(position.ToString());
            Console.SetIn(input);

            var output = new StringWriter();
            Console.SetOut(output);

            game.TakeTurn(mockPlayer1.Object);

            //Verifies that AddMark has been called once with these arguments
            Assert.True(mockBoard.HasAddMarkBeenCalled);


        }

        [Fact]
        public void ActivePlayer_DefaultsToPlayerOne_OnGameCreation()
        {

            Assert.Same(mockPlayer1.Object, game.ActivePlayer);

        }

        [Fact]
        public void SwitchPlayers_ChangesActivePlayer_ToOtherPlayer()
        {

            game.SwitchPlayers();

            Assert.Same(mockPlayer2.Object, game.ActivePlayer);

            game.SwitchPlayers();

            Assert.Same(mockPlayer1.Object, game.ActivePlayer);

        }
    }

}
