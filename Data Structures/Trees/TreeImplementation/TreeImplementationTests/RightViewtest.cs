using TreeImplementationPrj;

namespace TreeImplementationTests
{
    public class RightViewtest
    {
        [Fact]
        public void Test_RightView_WithGivenTree()
        {
            // Arrange
            BinaryTree Btree2 = new BinaryTree();
            Btree2.Root = new Node(2);
            Btree2.Root.Left = new Node(3);
            Btree2.Root.Right = new Node(5);
            Btree2.Root.Left.Left = new Node(4);
            Btree2.Root.Right.Right = new Node(6);
            Btree2.Root.Left.Left.Right = new Node(7);

            // Act
            var result = Btree2.PrintRightView();

            // Assert
            var expected = new List<int> { 2, 5, 6, 7 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_RightView_WithOnlyRightNodes()
        {
            // Arrange
            BinaryTree Btree2 = new BinaryTree();
            Btree2.Root = new Node(1);
            Btree2.Root.Right = new Node(2);
            Btree2.Root.Right.Right = new Node(3);
            Btree2.Root.Right.Right.Right = new Node(4);

            // Act
            var result = Btree2.PrintRightView();

            // Assert
            var expected = new List<int> { 1, 2, 3, 4 };
            Assert.Equal(expected, result);
        }
    }
}
