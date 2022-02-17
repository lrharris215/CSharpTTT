using System;
using System.IO;
using Xunit;

namespace TicTacToe.Test
{
    public class DisplayTest
    {
        [Theory]
        [InlineData("Testinggg")]
        [InlineData("Lots of outputs!!!! \n\n\n")]
        [InlineData("Everything outputs to the console!")]
        public void Print_Outputs_TheInputString(string testString)
        { 
            
            var output = new StringWriter();
            Console.SetOut(output);

            Display.Print(testString);
           
            Assert.Equal(testString, output.ToString());

        }

        // Unable to test the color change. Unsure if this is still needed. 
        [Fact]
        public void PrintError_OutputsString()
        {
            string input = "error";

            var output = new StringWriter();
            Console.SetOut(output);

            Display.PrintError(input);

            Assert.Equal(input, output.ToString());
            
        }
    }
}
