using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementationPrj;

namespace TreeImplementationTests
{
    public class MinimumDepthTests
    {
        [Fact]
        public void TestMinimumDepth_MultipleNodes_VaryingDepths()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);

            // Act
            int minDepth = tree.FindMinimumDepth();

            // Assert
            Assert.Equal(2, minDepth);
        }

        [Fact]
        public void TestMinimumDepth_EmptyTree()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();

            // Act
            int minDepth = tree.FindMinimumDepth();

            // Assert
            Assert.Equal(0, minDepth);
        }

        [Fact]
        public void TestMinimumDepth_SingleNodeTree()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);

            // Act
            int minDepth = tree.FindMinimumDepth();

            // Assert
            Assert.Equal(1, minDepth);
        }

        [Fact]
        public void TestMinimumDepth_UnbalancedTree()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Left.Right = new Node(5);
            tree.Root.Right = new Node(3);
            tree.Root.Right.Right = new Node(6);

            // Act
            int minDepth = tree.FindMinimumDepth();

            // Assert
            Assert.Equal(3, minDepth);
        }
    }
}
