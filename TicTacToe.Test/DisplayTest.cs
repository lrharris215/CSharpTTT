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
        public void Print_Gives_Input_to_Output_Function(string testString)
        { 
            
            var output = new StringWriter();
            Console.SetOut(output);

            Display.Print(testString);
           
            Assert.Equal(testString, output.ToString());

        }
    }
}
