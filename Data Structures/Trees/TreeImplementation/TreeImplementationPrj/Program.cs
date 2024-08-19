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
            bst.Print();
            Console.WriteLine(bst.FindSecondMax());
        }
    }
}
