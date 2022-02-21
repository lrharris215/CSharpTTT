using System;
using System.IO;
using Moq;
using Xunit;

namespace TicTacToe.Test
{
    public class ReceiverTest
    {
        [Theory]
        [InlineData("3")]
        [InlineData("INPUT")]
        [InlineData("AnotherThing!!")]
        public void GetInput_Receives_Player_Input(string input)
        {

            var consoleInput = new StringReader(input);
            Console.SetIn(consoleInput);

            Assert.Equal(Receiver.GetInput(), input);

        }

        [Fact]
        public void GetPlayerMove_ReturnsAValidPosition()
        {
            
            Mock<Validator> mockVal = new();

            string input = "3";
            var consoleInput = new StringReader(input);
            Console.SetIn(consoleInput);

            int position = 3;
        
            mockVal.Setup(mv => mv.IsValidMove(input, out position)).Returns(true);

            Assert.Equal(int.Parse(input), Receiver.GetPlayerMove(mockVal.Object));
        }
    }
}
