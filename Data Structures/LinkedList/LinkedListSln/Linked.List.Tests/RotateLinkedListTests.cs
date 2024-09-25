using LinkedListProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked.List.Tests
{
    public class RotateLinkedListTests
    {
        [Fact]
        public void RotateLeft_KEqualsZero_ListUnchanged()
        {
            // Arrange
            var linkedList = new LinkedList();
            linkedList.addArray(new int[] { 1, 2, 3, 4, 5 });

            var expectedList = new LinkedList();
            expectedList.addArray(new int[] { 1, 2, 3, 4, 5 });

            // Act
            linkedList.RotateLeft(0);

            // Assert
            Assert.True(linkedList.Equals(expectedList));
        }

        [Fact]
        public void RotateLeft_KGreaterThanLength_ListUnchanged()
        {
            // Arrange
            var linkedList = new LinkedList();
            linkedList.addArray(new int[] { 1, 2, 3, 4, 5 });

            var expectedList = new LinkedList();
            expectedList.addArray(new int[] { 1, 2, 3, 4, 5 });

            // Act
            linkedList.RotateLeft(7); // Length of the list is 5

            // Assert
            Assert.True(linkedList.Equals(expectedList));
        }

    }
}
