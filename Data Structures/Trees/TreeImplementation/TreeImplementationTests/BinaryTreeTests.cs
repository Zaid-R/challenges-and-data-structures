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
        [Fact]
        public void TestFindSecondMax_BasicExample()
        {
            // Arrange
            var bst = new BinaryTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(20);
            bst.Add(3);
            bst.Add(7);
            bst.Add(15);
            bst.Add(25);

            // Act
            var secondMax = bst.FindSecondMax();

            // Assert
            Assert.Equal(20, secondMax);
        }

        [Fact]
        public void TestFindSecondMax_LessThanTwoUniqueValues()
        {
            // Arrange
            var bst = new BinaryTree();
            bst.Add(10);

            // Act
            var secondMax = bst.FindSecondMax();

            // Assert
            Assert.Null(secondMax);
        }

        [Fact]
        public void TestFindSecondMax_WithNegativeValues()
        {
            // Arrange
            var bst = new BinaryTree();
            bst.Add(-10);
            bst.Add(-20);
            bst.Add(-30);
            bst.Add(-5);
            bst.Add(-15);

            // Act
            var secondMax = bst.FindSecondMax();

            // Assert
            Assert.Equal(-10, secondMax);
        }
        [Fact]
        public void LeafSum_ShouldReturnCorrectSum_ForPositiveLeafValues()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(9);
            Btree.Root.Left = new Node(8);
            Btree.Root.Right = new Node(12);
            Btree.Root.Left.Left = new Node(3);
            Btree.Root.Left.Right = new Node(7);
            Btree.Root.Right.Left = new Node(17);
            Btree.Root.Right.Right = new Node(23);
            Btree.Root.Left.Left.Right = new Node(4);

            // Act
            int sumOfLeaves = Btree.LeafSum();

            // Assert
            Assert.Equal(51, sumOfLeaves); // Leaf nodes: 4, 7, 17, 23. Sum: 4 + 7 + 17 + 23 = 51
        }

        [Fact]
        public void LeafSum_ShouldReturnCorrectSum_ForNegativeLeafValues()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Add(9);
            Btree.Add(8);
            Btree.Add(12);
            Btree.Add(3);
            Btree.Add(7);
            Btree.Add(17);
            Btree.Add(23);
            Btree.Add(-4); // Adding a negative leaf value

            // Act
            int sumOfLeaves = Btree.LeafSum();

            // Assert
            Assert.Equal(26, sumOfLeaves); // Leaf nodes: -4, 7, 23. Sum: -4 + 7 + 23 = 26
        }

        [Fact]
        public void LargestValueEachLevel_ShouldReturnCorrectSum()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(5);
            Btree.Root.Left = new Node(13);
            Btree.Root.Right = new Node(7);
            Btree.Root.Left.Left = new Node(3);
            Btree.Root.Left.Right = new Node(7);
            Btree.Root.Right.Left = new Node(12);
            Btree.Root.Right.Right = new Node(20);
            Btree.Root.Left.Left.Left = new Node(1);
            Btree.Root.Left.Left.Right = new Node(4);
            Btree.Root.Right.Left.Right = new Node(11);

            // Act
            List<int> largestValues = Btree.LargestValueEachLevel();
            int sumOfLargestValues = largestValues.Sum();

            // Assert
            Assert.Equal(49, sumOfLargestValues); // The sum of [5, 13, 20, 11] should be 49
        }
    }
}