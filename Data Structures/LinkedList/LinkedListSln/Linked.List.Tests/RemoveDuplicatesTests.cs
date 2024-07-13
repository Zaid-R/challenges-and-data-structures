
using LinkedListProject;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Linked.List.Tests
{
    public class RemoveDuplicatesTests
    {
        public static bool AreArraysEqual(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            var sortedArray1 = array1.OrderBy(x => x).ToArray();
            var sortedArray2 = array2.OrderBy(x => x).ToArray();

            return sortedArray1.SequenceEqual(sortedArray2);
        }

        [Fact]
        public void LinkedList_Remains_Unchanged_When_There_No_Duplicate_Nodes()
        {
            // Arrange
            // values = {10, 20, 30}
            var list = linkedlistClassTests.initLinkedList(new[] { 10,20,30});

            // Act
            list.RemoveDuplicate();
            int[] listAfterRemove = new int[list.Length];
            Node? tracker = list.Head;
            int i = 0; 
            while (tracker != null) {
                listAfterRemove[i++] = tracker.value;
                tracker = tracker.next;
            }

            // Assert
            Assert.True(AreArraysEqual(listAfterRemove,new[] { 10, 20, 30 }));
        }

        [Fact]
        public void On_Duplicate_Nodes_Are_Removed()
        {
            // Arrange
            // values = {10, 20, 30}
            var list = linkedlistClassTests.initLinkedList(new[] { 1, 2, 3, 2, 4, 3 });

            // Act
            list.RemoveDuplicate();
            int[] listAfterRemove = new int[list.Length];
            Node? tracker = list.Head;
            int i = 0;
            while (tracker != null)
            {
                listAfterRemove[i++] = tracker.value;
                tracker = tracker.next;
            }

            // Assert
            Assert.True(AreArraysEqual(listAfterRemove,new[] { 1,2,3,4 }));
        }

        [Fact]
        public void LinkedList_AllNodesAreDuplicates_ReducesToSingleNode()
        {
            // Arrange
            // values = {10, 20, 30}
            var list = linkedlistClassTests.initLinkedList(new[] { 7,7,7,7 });

            // Act
            list.RemoveDuplicate();
            int[] listAfterRemove = new int[list.Length];
            Node? tracker = list.Head;
            int i = 0;
            while (tracker != null)
            {
                listAfterRemove[i++] = tracker.value;
                tracker = tracker.next;
            }

            // Assert
            Assert.True(AreArraysEqual(listAfterRemove, new[] {7}));
        }
    }
}