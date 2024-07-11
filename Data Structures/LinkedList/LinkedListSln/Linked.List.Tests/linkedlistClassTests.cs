using LinkedListProject;

namespace Linked.List.Tests
{
    public class linkedlistClassTests
    {
        private LinkedListProject.LinkedList initLinkedList()
        {
            LinkedList list = new LinkedList(new Node(5));
            int[] values = { 10, 20, 30 };
            foreach (int value in values)
            {
                list.Add(value);
            }
            return list;
        }

        [Fact]
        public void Remove_Node_From_The_End_Of_LinkedList()
        {
            // Arrange
            LinkedList list = initLinkedList();

            //Act
            int oldTailValue = list.tail!.value;
            list.Remove(oldTailValue);

            // Assert
            Assert.NotEqual(oldTailValue, list.tail!.value);
        }

        [Fact]
        public void Test_PrintList_Method()
        {
            // Arrange
            LinkedList list = initLinkedList();

            // Act
            string expectedOutput = "Head -> 5 -> 10 -> 20 -> 30 -> Null";

            // Assert
            Assert.Equal(expectedOutput, list.PrintList());
        }
    }
}