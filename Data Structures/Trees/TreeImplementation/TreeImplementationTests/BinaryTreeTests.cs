using TreeImplementationPrj;

namespace TreeImplementationTests
{
    public class BinaryTreeTests
    {
        [Fact]
        public void PreOrderTraversal_Test()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Add(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(3);
            tree.Add(7);

            List<int> expected = new List<int> { 10, 5, 3, 7, 15 };
            List<int> actual = new List<int>();

            // Act
            tree.PreOrderTraversal(tree.GetRoot(), actual);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InOrderTraversal_Test()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Add(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(3);
            tree.Add(7);

            List<int> expected = new List<int> { 3, 5, 7, 10, 15 };
            List<int> actual = new List<int>();

            // Act
            tree.InOrderTraversal(tree.GetRoot(), actual);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PostOrderTraversal_Test()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Add(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(3);
            tree.Add(7);

            List<int> expected = new List<int> { 3, 7, 5, 15, 10 };
            List<int> actual = new List<int>();

            // Act
            tree.PostOrderTraversal(tree.GetRoot(), actual);

            // Assert
            Assert.Equal(expected, actual);
        }
    }

}