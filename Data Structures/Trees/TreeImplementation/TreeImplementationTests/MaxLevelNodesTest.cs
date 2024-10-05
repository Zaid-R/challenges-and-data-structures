
using TreeImplementationPrj;

namespace TreeImplementationTests
{
    public class MaxLevelNodesTest
    {

        [Fact]
        public void Test_FindMaxLevelNodes_SingleMaxLevel()
        {
            // Arrange
            var tree = new int[] { 1, 2, 3, 4, 5, -1, -1 };
            var binaryTree = new BinaryTree(); // Assuming BinaryTree takes the root node as parameter
            foreach (var value in tree) { 
                binaryTree.Add(value);
            }

            // Act
            int result = binaryTree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(1, result); // Level 1 has the maximum number of nodes
        }

        [Fact]
        public void Test_FindMaxLevelNodes_MultipleMaxLevels()
        {
            // Arrange
            var binaryTree = new BinaryTree(); // Assuming BinaryTree takes the root node as parameter
            binaryTree.Root = new Node(1);
            binaryTree.Root.Right = new Node(2);
            binaryTree.Root.Left = new Node(3);
            binaryTree.Root.Left.Right = new Node(4);
            binaryTree.Root.Left.Left = new Node(5);
            binaryTree.Root.Right.Right = new Node(6);
            binaryTree.Root.Right.Left = new Node(7);
            // Act
            int result = binaryTree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(2, result); // Level 2 has the maximum number of nodes
        }

        [Fact]
        public void Test_FindMaxLevelNodes_EmptyTree()
        {
            // Arrange
            var binaryTree = new BinaryTree(); // Creating an empty tree

            // Act
            int result = binaryTree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(-1, result); // Should return -1 for an empty tree
        }
    }
}
