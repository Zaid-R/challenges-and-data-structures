namespace TreeImplementationPrj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bst = new BinaryTree();

            // Add nodes to the BST
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(7);
            bst.Print();
            // Check if a node exists
            bool contains = bst.Contains(7); // contains: true
            Console.WriteLine($"Does tree contain 7: ${contains}");
            // Remove a node
            bst.Remove(5);
            Console.WriteLine("Tree after removing 5");
            bst.Print();
            // Check if the node is removed
            contains = bst.Contains(5); // contains: false
            Console.WriteLine($"Does tree contain 5: ${contains}");
            bst.MirrorTree();
            bst.Print();
            Console.ReadKey();
        }
    }
}
