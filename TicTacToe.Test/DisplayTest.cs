using System;
using System.IO;
using TicTacToe;
using Xunit;

namespace TicTacToe.Test
{
    public class DisplayTest
    {
        [Fact]
        public void Print_Gives_Input_to_Output_Function()
        { 
            
            var output = new StringWriter();
            Console.SetOut(output);

            string testString = "Testtesttest";

            Display.Print(testString);
           

            Assert.Equal(output.ToString(), testString);

        }
    }
}
