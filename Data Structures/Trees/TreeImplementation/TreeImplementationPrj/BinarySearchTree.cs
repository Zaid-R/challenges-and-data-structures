using System.Xml.Linq;

namespace TreeImplementationPrj
{

    public class BinarySearchTree
    {
        public Node Root { get; set; }
        public Node GetRoot() => Root;

        public void Add(int value) => Insert(Root, value);
        public bool Contains(int value) => Search(Root, value);
        private bool Search(Node node, int value)
        {
            if (node == null) return false;
            if (value == node.Value) return true;
            if (value < node.Value) return Search(node.Left, value);
            return Search(node.Right, value);
        }

        private void Insert(Node node, int value)
        {
            if (Root is null)
            {
                Root = new Node(value);
            }
            else if (value < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(value);
                }
                else
                {
                    Insert(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new Node(value);
                }
                else
                {
                    Insert(node.Right, value);
                }
            }
        }
        /// <summary>
        /// Return true if the value does exist and delete it, otherwise return false 
        /// </summary>
        /// <param name="value"></param>
        /// <returns>bool</returns>
        public bool Remove(int value) =>  Remove(Root, value) is not null;
        

        private Node? Remove(Node node, int value)
        {
            if (node == null) return null;

            if (value < node.Value)
            {
                node.Left = Remove(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = Remove(node.Right, value);
            }
            else
            {
                // Node with only one child or no child
                if (node.Left == null)
                    return node.Right;
                else if (node.Right == null)
                    return node.Left;

                // Node with two children: Get the inorder successor (smallest in the right subtree)
                node.Value = MinValue(node.Right);

                // Delete the inorder successor
                node.Right = Remove(node.Right, node.Value);
            }

            return node;
        }

        private int MinValue(Node node)
        {
            int minValue = node.Value;
            while (node.Left != null)
            {
                minValue = node.Left.Value;
                node = node.Left;
            }
            return minValue;
        }
    }
}
