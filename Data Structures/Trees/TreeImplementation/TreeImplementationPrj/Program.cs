using System.Linq;

namespace TreeImplementationPrj
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(35);
            Btree.Root.Left = new Node(20);
            Btree.Root.Right = new Node(50);
            Btree.Root.Left.Left = new Node(10);
            Btree.Root.Left.Right = new Node(40);
            Btree.Root.Right.Right = new Node(60);
            Btree.Root.Left.Left.Left = new Node(5);
            //Btree.Root.Left.Right.Right = new Node(35);

            Console.WriteLine("Before converting to BST:");
            Btree.Print();
            Btree.ConvertToBST();
            Console.WriteLine("\nAfter converting to BST:");
            Btree.Print();

        }
    }
}
