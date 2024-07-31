using StackAndQueuePrj;

namespace StackAndQueueTests
{
    public class StackWithReverseTests
    {
        [Fact]
        public void TestReversingStackWithMultipleElements()
        {
            // Arrange
            StackWithReverse stack = new StackWithReverse();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Act
            stack.ReverseStack();

            // Assert
            Assert.Equal("Top -> 1 -> 2 -> 3", stack.ToString());
        }

        [Fact]
        public void TestReversingStackWithOneElement()
        {
            // Arrange
            StackWithReverse stack = new StackWithReverse();
            stack.Push(1);

            // Act
            stack.ReverseStack();

            // Assert
            Assert.Equal("Top -> 1", stack.ToString());
        }

        [Fact]
        public void TestReversingEmptyStack()
        {
            // Arrange
            StackWithReverse stack = new StackWithReverse();

            // Act
            stack.ReverseStack();

            // Assert
            Assert.Equal("Top -> Null", stack.ToString());
        }
    }
}
