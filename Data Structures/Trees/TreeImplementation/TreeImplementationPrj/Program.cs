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
            Btree.Add(9);
            Btree.Add(8);
            Btree.Add(12);
            Btree.Add(3);
            Btree.Add(7);
            Btree.Add(17);
            Btree.Add(23);
            Btree.Add(-4);
            Btree.Print();

        }
    }
}
