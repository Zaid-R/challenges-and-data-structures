
using System.Xml.Linq;

namespace TreeImplementationPrj
{

    public class BinaryTree : BinarySearchTree
    {
        class NodeInfo
        {
            public Node Node;
            public string Text;
            public int StartPos;
            public int Size { get { return Text.Length; } }
            public int EndPos { get { return StartPos + Size; } set { StartPos = value - Size; } }
            public NodeInfo Parent, Left, Right;
        }
        public void Print() => Print(Root);
        private void Print(Node root, string textFormat = "0", int spacing = 1, int topMargin = 2, int LeftMargin = 2)
        {
            if (root == null) return;
            int rootTop = Console.CursorTop + topMargin;
            var last = new List<NodeInfo>();
            var next = root;
            for (int level = 0; next != null; level++)
            {
                var item = new NodeInfo { Node = next, Text = next.Value.ToString(textFormat) };
                if (level < last.Count)
                {
                    item.StartPos = last[level].EndPos + spacing;
                    last[level] = item;
                }
                else
                {
                    item.StartPos = LeftMargin;
                    last.Add(item);
                }
                if (level > 0)
                {
                    item.Parent = last[level - 1];
                    if (next == item.Parent.Node.Left)
                    {
                        item.Parent.Left = item;
                        item.EndPos = Math.Max(item.EndPos, item.Parent.StartPos - 1);
                    }
                    else
                    {
                        item.Parent.Right = item;
                        item.StartPos = Math.Max(item.StartPos, item.Parent.EndPos + 1);
                    }
                }
                next = next.Left ?? next.Right;
                for (; next == null; item = item.Parent)
                {
                    int top = rootTop + 2 * level;
                    Print(item.Text, top, item.StartPos);
                    if (item.Left != null)
                    {
                        Print("/", top + 1, item.Left.EndPos);
                        Print("_", top, item.Left.EndPos + 1, item.StartPos);
                    }
                    if (item.Right != null)
                    {
                        Print("_", top, item.EndPos, item.Right.StartPos - 1);
                        Print("\\", top + 1, item.Right.StartPos - 1);
                    }
                    if (--level < 0) break;
                    if (item == item.Parent.Left)
                    {
                        item.Parent.StartPos = item.EndPos + 1;
                        next = item.Parent.Node.Right;
                    }
                    else
                    {
                        if (item.Parent.Left == null)
                            item.Parent.EndPos = item.StartPos - 1;
                        else
                            item.Parent.StartPos += (item.StartPos - 1 - item.Parent.EndPos) / 2;
                    }
                }
            }
            Console.SetCursorPosition(0, rootTop + 2 * last.Count - 1);
        }

        private static void Print(string s, int top, int Left, int Right = -1)
        {
            Console.SetCursorPosition(Left, top);
            if (Right < 0) Right = Left + s.Length;
            while (Console.CursorLeft < Right) Console.Write(s);
        }
        // ( Root - Left - Right )
        // Pre-order traversal (Root - Left - Right)
        public void PreOrderTraversal(Node node, List<int> result)
        {
            if (node == null) return;
            result.Add(node.Value);
            PreOrderTraversal(node.Left, result);
            PreOrderTraversal(node.Right, result);
        }

        // In-order traversal (Left - Root - Right)
        public void InOrderTraversal(Node node, List<int> result)
        {
            if (node == null) return;
            InOrderTraversal(node.Left, result);
            result.Add(node.Value);
            InOrderTraversal(node.Right, result);
        }

        // Post-order traversal (Left - Right - Root)
        public void PostOrderTraversal(Node node, List<int> result)
        {
            if (node == null) return;
            PostOrderTraversal(node.Left, result);
            PostOrderTraversal(node.Right, result);
            result.Add(node.Value);
        }


        /// <summary>
        /// Converts the binary tree into its mirror image.
        /// </summary>
        public void MirrorTree() => Mirror(Root);

        private void Mirror(Node node)
        {
            if (node == null) return;

            // Recursively mirror the left and right subtrees
            Mirror(node.Left);
            Mirror(node.Right);

            // Swap the left and right children
            var temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;
        }

        /// <summary>
        /// Finds the second maximum value in the binary tree.
        /// </summary>
        /// <returns>The second maximum value, or null if it doesn't exist.</returns>
        public int? FindSecondMax()
        {
            if (Root == null || (Root.Left == null && Root.Right == null))
            {
                // Tree is empty or has only one node, no second max exists
                return null;
            }

            Node current = Root;
            Node parent = null;

            // Traverse to the rightmost node
            while (current.Right != null)
            {
                parent = current;
                current = current.Right;
            }

            // If the rightmost node has a left subtree, find the rightmost node in that subtree
            if (current.Left != null)
            {
                current = current.Left;
                while (current.Right != null)
                {
                    current = current.Right;
                }
                return current.Value;
            }

            // Otherwise, the parent of the rightmost node is the second maximum
            return parent?.Value;
        }

        /// <summary>
        /// Calculates the sum of all leaf nodes in the binary tree.
        /// </summary>
        /// <returns>The sum of values of all leaf nodes.</returns>
        public int LeafSum()
        {
            return LeafSum(Root);
        }

        private int LeafSum(Node node)
        {
            if (node == null)
                return 0;

            // Check if it's a leaf node (no children)
            if (node.Left == null && node.Right == null)
                return node.Value;

            // Recursively calculate the sum of leaf nodes in the left and right subtrees
            int leftSum = LeafSum(node.Left);
            int rightSum = LeafSum(node.Right);

            // Return the sum of leaf nodes
            return leftSum + rightSum;
        }

        /// <summary>
        /// Returns a list of the largest values at each level of the binary tree.
        /// </summary>
        /// <returns>List of integers representing the largest value at each level.</returns>
        public List<int> LargestValueEachLevel()
        {
            var result = new List<int>();
            if (Root == null) return result;

            var queue = new Queue<Node>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                int maxValue = int.MinValue;

                for (int i = 0; i < levelSize; i++)
                {
                    var node = queue.Dequeue();
                    if (node.Value > maxValue)
                    {
                        maxValue = node.Value;
                    }

                    if (node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                    }

                    if (node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                    }
                }

                result.Add(maxValue);
            }

            return result;
        }

        /// <summary>
        /// Prints the rightmost node at each level of the binary tree.
        /// This effectively displays the "right view" of the tree.
        /// </summary>
        public List<int> PrintRightView()
        {
            var result = new List<int>();
            if (Root == null)
            {
                Console.WriteLine("The tree is empty.");
                return result;
            }

            var queue = new Queue<Node>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                Node rightmostNode = null;

                for (int i = 0; i < levelSize; i++)
                {
                    var node = queue.Dequeue();
                    rightmostNode = node; // Capture the last node at each level

                    if (node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                    }

                    if (node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                    }
                }

                // Print the rightmost node for this level
                result.Add(rightmostNode.Value);
            }
            return result;
        }

        public int FindMaxLevelNodes()
        {
            if (Root == null)
                return -1; // Indicates the tree is empty

            var queue = new Queue<Node>();
            queue.Enqueue(Root);

            int maxLevel = 0;
            int maxNodes = 0;
            int currentLevel = 0;

            while (queue.Count > 0)
            {
                int levelSize = queue.Count; // Number of nodes at the current level

                // Check if the current level has more nodes than previous levels
                if (levelSize > maxNodes)
                {
                    maxNodes = levelSize;
                    maxLevel = currentLevel;
                }

                for (int i = 0; i < levelSize; i++)
                {
                    var node = queue.Dequeue();

                    // Enqueue children for the next level
                    if (node.Left != null)
                        queue.Enqueue(node.Left);
                    if (node.Right != null)
                        queue.Enqueue(node.Right);
                }

                currentLevel++;
            }

            return maxLevel;
        }

    }
}
