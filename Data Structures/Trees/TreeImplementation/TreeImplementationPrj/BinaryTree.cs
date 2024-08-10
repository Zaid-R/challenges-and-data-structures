
using System.Xml.Linq;

namespace TreeImplementationPrj
{

    public class BinaryTree: BinarySearchTree
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
    }
}
