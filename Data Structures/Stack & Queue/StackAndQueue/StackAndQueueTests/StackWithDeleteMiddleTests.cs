using StackAndQueuePrj;
namespace StackAndQueueTests
{
    public class StackWithDeleteMiddleTests
    {
        [Fact]
        public void DeleteMiddle_OddSizedStack_RemovesMiddleElement()
        {
            // Arrange
            var stack = new StackWithDeleteMiddle();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            // Act
            stack.DeleteMiddle();

            // Assert
            Assert.Equal("Top -> 5 -> 4 -> 2 -> 1", stack.ToString());
        }

        [Fact]
        public void DeleteMiddle_EvenSizedStack_RemovesMiddleElement()
        {
            // Arrange
            var stack = new StackWithDeleteMiddle();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            // Act
            stack.DeleteMiddle();

            // Assert
            Assert.Equal("Top -> 6 -> 5 -> 4 -> 2 -> 1", stack.ToString());
        }
    }
}
