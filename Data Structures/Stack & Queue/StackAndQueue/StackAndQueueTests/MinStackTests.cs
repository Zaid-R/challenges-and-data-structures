using StackAndQueuePrj;

namespace StackAndQueueTests
{
    public class MinStackTests
    {
        [Fact]
        public void Test_GetMin()
        {
            // Arrange
            MinStack minStack = new MinStack();
            minStack.Push(3);
            minStack.Push(5);
            minStack.Push(2);
            minStack.Push(1);

            // Act
            int min = minStack.GetMin();

            // Assert
            Assert.Equal(1, min);
        }

        [Fact]
        public void Test_Pop_And_Verify_Min_After_Pop()
        {
            // Arrange
            MinStack minStack = new MinStack();
            minStack.Push(3);
            minStack.Push(5);
            minStack.Push(2);
            minStack.Push(1);

            // Act
            minStack.Pop(); // Removes 1
            int minAfterPop = minStack.GetMin(); // Should be 2

            // Assert
            Assert.Equal(2, minAfterPop);
        }

        [Fact]
        public void Test_Push_And_Verify_Min_After_Push()
        {
            // Arrange
            MinStack minStack = new MinStack();

            // Act
            minStack.Push(3);
            int minAfterFirstPush = minStack.GetMin(); // Should be 3

            minStack.Push(5);
            int minAfterSecondPush = minStack.GetMin(); // Should be 3

            minStack.Push(2);
            int minAfterThirdPush = minStack.GetMin(); // Should be 2

            minStack.Push(1);
            int minAfterFourthPush = minStack.GetMin(); // Should be 1

            // Assert
            Assert.Equal(3, minAfterFirstPush);
            Assert.Equal(3, minAfterSecondPush);
            Assert.Equal(2, minAfterThirdPush);
            Assert.Equal(1, minAfterFourthPush);
        }
    }
}
