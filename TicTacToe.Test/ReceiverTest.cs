using System;
using System.IO;
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
    }
}
