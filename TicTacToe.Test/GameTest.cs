using System;
using System.IO;
using Moq;
using Xunit;

namespace TicTacToe.Test
{
    public class GameTest
    {

        Player player1;
        Player player2;
        MockBoard mockBoard;
        Mock<Validator> mockValidator;

        Game game;

        public GameTest()
        {
            mockBoard = new MockBoard();


            player1 = new Player("Player One", 'X');
            player2 = new Player("Player Two", 'O');
            mockValidator = new Mock<Validator>();

            game = new Game(mockBoard, mockValidator.Object, player1, player2);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(9)]
        public void TakeTurn_PlacesAValidMark_OnTheBoard(int position)
        { 
            mockValidator.Setup(mv => mv.IsValidMove(position.ToString(), out position)).Returns(true);

            var input = new StringReader(position.ToString());
            Console.SetIn(input);

            var output = new StringWriter();
            Console.SetOut(output);

            game.TakeTurn(player1);

            //Verifies that AddMark has been called once with these arguments
            Assert.True(mockBoard.HasAddMarkBeenCalled);


        }

        [Fact]
        public void ActivePlayer_DefaultsToPlayerOne_OnGameCreation()
        {

            Assert.Same(player1, game.ActivePlayer);

        }

        [Fact]
        public void SwitchPlayers_ChangesActivePlayer_ToOtherPlayer()
        {

            game.SwitchPlayers();

            Assert.Same(player2, game.ActivePlayer);

            game.SwitchPlayers();

            Assert.Same(player1, game.ActivePlayer);

        }

        [Theory]
        [InlineData("Player One", 'X')]
        [InlineData("Player Two", 'O')]
        public void EndGame_DeclaresWinner_WhenGameIsNotATie(string  playerName, char winnerMark)
        {
            var output = new StringWriter();
            Console.SetOut(output);

            game.EndGame(winnerMark.ToString());

            Assert.Equal(Constants.GameOverWinner(playerName), output.ToString());
        }

        [Fact]
        public void EndGame_DeclaresTie_WhenGameIsTie()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            game.EndGame("Tie");

            Assert.Equal(Constants.GameOverTie, output.ToString());
        }
    }

}
