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

        [Fact]
        public void MirrorTree_InorderTraversal_ShouldReturnMirrorImage()
        {
            // Arrange
            var bst = new BinaryTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(2);
            bst.Add(7);

            // Act
            bst.MirrorTree();
            List<int> result = new();
            bst.InOrderTraversal(bst.GetRoot(), result);

            // Assert
            var expected = new int[] { 15, 10, 7, 5, 2 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MirrorTree_SingleNodeTree_ShouldRemainTheSame()
        {
            // Arrange
            var bst = new BinaryTree();
            bst.Add(10);

            // Act
            bst.MirrorTree();
            List<int> result = new();
            bst.InOrderTraversal(bst.GetRoot(), result);

            // Assert
            var expected = new int[] { 10 };
            Assert.Equal(expected, result);
        }
        [Fact]
        public void MirrorTree_EmptyTree_ShouldRemainNull()
        {
            // Arrange
            var bst = new BinaryTree();

            // Act
            bst.MirrorTree();
            var result = bst.GetRoot();

            // Assert
            Assert.Null(result);
        }
    }
}