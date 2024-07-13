using LinkedListProject;

namespace Linked.List.Tests
{
    public class linkedlistClassTests
    {
        public static LinkedListProject.LinkedList initLinkedList(int[]? arr = null)
        {
            if (arr == null || arr.Length == 0)
            {
                arr = new int[] { 5, 10, 20, 30 };
            }
            LinkedList list = new LinkedList(new Node(arr[0]));
            for (int i = 1; i < arr.Length; i++)
            {
                list.Add(arr[i]);
            }
            return list;
        }

        [Fact]
        public void Remove_Node_From_The_End_Of_LinkedList()
        {
            // Arrange
            LinkedList list = initLinkedList();

            //Act
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
            LinkedList list = initLinkedList();

            // Act
            string expectedOutput = "Head -> 5 -> 10 -> 20 -> 30 -> Null";

            // Assert
            Assert.Equal(expectedOutput, list.PrintList());
        }
    }
}