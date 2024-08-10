using TreeImplementationPrj;

namespace TreeImplementationTests
{
    public class BinarySearchTreeTests
    {
        [Fact]
        public void AddNode_Test()
        {
            // Arrange
            BinarySearchTree bst = new BinarySearchTree();

            // Act
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(3);
            bst.Add(7);

            // Assert
            Assert.True(bst.Contains(10)); // Check if root node was added
            Assert.True(bst.Contains(5));  // Check if left child was added
            Assert.True(bst.Contains(15)); // Check if right child was added
            Assert.True(bst.Contains(3));  // Check if left-left child was added
            Assert.True(bst.Contains(7));  // Check if left-right child was added
        }

        [Fact]
        public void ContainsNode_Test()
        {
            // Arrange
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);

            // Act & Assert
            Assert.True(bst.Contains(10)); // Check if root node exists
            Assert.True(bst.Contains(5));  // Check if left child exists
            Assert.True(bst.Contains(15)); // Check if right child exists
            Assert.False(bst.Contains(7)); // Check if a non-existent node returns false
        }

        [Fact]
        public void RemoveNode_Test()
        {
            // Arrange
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(3);
            bst.Add(7);

            // Act
            bool removed = bst.Remove(5);

            // Assert
            Assert.True(removed);            // Check if the node was removed
            Assert.False(bst.Contains(5));   // Check if the node no longer exists
            Assert.True(bst.Contains(10));   // Ensure the root still exists
            Assert.True(bst.Contains(3));    // Ensure the left-left child still exists
            Assert.True(bst.Contains(7));    // Ensure the left-right child still exists
            Assert.True(bst.Contains(15));   // Ensure the right child still exists
        }
    }

}