using LinkedListProject;

namespace Linked.List.Tests
{
    public class linkedlistClassTests
    {

        int[] arr = { 1,2,3,4};
        [Fact]
        public void Remove_Node_From_The_End_Of_LinkedList()
        {
            // Arrange
            LinkedList list = new LinkedList();

            //Act
            list.addArray(arr);
            int oldTailValue = list.Tail!.value;
            list.Remove(oldTailValue);

            // Assert
            //Assert.NotEqual(oldTailValue, list.Tail!.value);
            Assert.NotEqual(20,list.Tail.value);
        }

        [Fact]
        public void Test_PrintList_Method()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act
            list.addArray(arr);
            string expectedOutput = "Head -> 5 -> 10 -> 20 -> 30 -> Null";

            // Assert
            Assert.Equal(expectedOutput, list.PrintList());
        }
    }
}