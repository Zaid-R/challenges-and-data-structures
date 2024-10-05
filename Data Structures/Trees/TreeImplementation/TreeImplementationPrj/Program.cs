using System.Linq;

namespace TreeImplementationPrj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bst = new BinaryTree();

            // Add nodes to the BST
            bst.Add(10);
            bst.Add(20);
            bst.Add(15);
            bst.Add(18);
            //bst.Print();
            //Console.WriteLine(bst.FindSecondMax());
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

            List<int> largestValues = Btree.LargestValueEachLevel();
            Console.WriteLine(String.Join(',', largestValues));
            Btree.Print();

            BinaryTree Btree2 = new BinaryTree();
            Btree2.Root = new Node(2);
            Btree2.Root.Left = new Node(3);
            Btree2.Root.Right = new Node(5);
            Btree2.Root.Left.Left = new Node(4);
            Btree2.Root.Right.Right = new Node(6);
            Btree2.Root.Left.Left.Right = new Node(7);

            Console.WriteLine(String.Join(" ",Btree2.PrintRightView()));

            var tree = new int[] { 1, 2, 3, 4, 5, 6, 7 }; // Level 0: 1, Level 1: 2, 3, Level 2: 4, 5, 6, 7
            var binaryTree = new BinaryTree();
            binaryTree.Root = new Node(1);
            binaryTree.Root.Right = new Node(2);
            binaryTree.Root.Left = new Node(3);
            binaryTree.Root.Left.Right = new Node(4);
            binaryTree.Root.Left.Left = new Node(5);
            binaryTree.Root.Right.Right = new Node(6);
            binaryTree.Root.Right.Left = new Node(7);
            binaryTree.Print();
        }
    }
}
