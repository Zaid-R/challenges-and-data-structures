using System.Linq;

namespace TreeImplementationPrj
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BinaryTree Btree2 = new BinaryTree();
            Btree2.Root = new Node(2);
            Btree2.Root.Left = new Node(3);
            Btree2.Root.Right = new Node(5);
            Btree2.Root.Left.Left = new Node(4);
            Btree2.Root.Right.Right = new Node(6);
            Btree2.Root.Left.Left.Right = new Node(7);

            Console.WriteLine(String.Join(" ",Btree2.PrintRightView()));

            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Left.Right = new Node(5);

            int minDepth = Btree.FindMinimumDepth(); // Output: 2
            Console.WriteLine("minDepth {0}",minDepth);
        }
    }
}
