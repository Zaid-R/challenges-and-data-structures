using System;
using Xunit;
using ReverseWords;
namespace ReverseWordsTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Reverse_Words_Method()
        {
            // Act
            string input = "csharp is programming language";

            // Assert
            Assert.Equal("language programming is csharp",Program.ReverseWords(input));

            // Act
            input = "Reverse the words in this sentence";

            // Assert
            Assert.Equal("sentence this in words the Reverse", Program.ReverseWords(input));
            
            // Act
            input = "challenges and data structures";

            // Assert
            Assert.Equal("structures data and challenges", Program.ReverseWords(input));
        }
    }
}