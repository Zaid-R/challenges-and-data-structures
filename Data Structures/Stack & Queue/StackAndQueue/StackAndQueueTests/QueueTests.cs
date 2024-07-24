using StackAndQueuePrj;

namespace StackAndQueueTests
{
    public class QueueTests
    {
        [Fact]
        public void Enqueue_ShouldAddNodeToQueue()
        {
            // Arrange
            var queue = new Queue();

            // Act
            queue.Enqueue(1);

            // Assert
            Assert.False(queue.IsEmpty());
            Assert.Equal(1, queue.Peek());
        }

        [Fact]
        public void Dequeue_ShouldRemoveAndReturnFrontNodeData()
        {
            // Arrange
            var queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);

            // Act
            int dequeuedValue = queue.Dequeue();

            // Assert
            Assert.Equal(1, dequeuedValue);
            Assert.False(queue.IsEmpty());
            Assert.Equal(2, queue.Peek());
        }

        [Fact]
        public void IsEmpty_ShouldReturnTrue_WhenQueueIsEmpty()
        {
            // Arrange
            var queue = new Queue();

            // Act
            bool isEmpty = queue.IsEmpty();

            // Assert
            Assert.True(isEmpty);
        }

        [Fact]
        public void IsEmpty_ShouldReturnFalse_WhenQueueIsNotEmpty()
        {
            // Arrange
            var queue = new Queue();
            queue.Enqueue(1);

            // Act
            bool isEmpty = queue.IsEmpty();

            // Assert
            Assert.False(isEmpty);
        }
    }
}
