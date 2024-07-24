using StackAndQueuePrj;

namespace StackAndQueueTests
{
    public class StackTests
    {

        [Fact]
        public void Push_ShouldAddNodeToStack()
        {
            // Arrange
            var stack = new Stack();

            // Act
            stack.Push(1);

            // Assert
            Assert.False(stack.IsEmpty());
            Assert.Equal(1, stack.Peek());
        }

        [Fact]
        public void Pop_ShouldRemoveAndReturnTopNodeData()
        {
            // Arrange
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);

            // Act
            int poppedValue = stack.Pop();

            // Assert
            Assert.Equal(2, poppedValue);
            Assert.False(stack.IsEmpty());
            Assert.Equal(1, stack.Peek());
        }

        [Fact]
        public void IsEmpty_ShouldReturnTrue_WhenStackIsEmpty()
        {
            // Arrange
            var stack = new Stack();

            // Act
            bool isEmpty = stack.IsEmpty();

            // Assert
            Assert.True(isEmpty);
        }

        [Fact]
        public void IsEmpty_ShouldReturnFalse_WhenStackIsNotEmpty()
        {
            // Arrange
            var stack = new Stack();
            stack.Push(1);

            // Act
            bool isEmpty = stack.IsEmpty();

            // Assert
            Assert.False(isEmpty);
        }
    }

}