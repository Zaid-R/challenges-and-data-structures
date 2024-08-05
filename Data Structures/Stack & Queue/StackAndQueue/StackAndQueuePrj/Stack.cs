
namespace StackAndQueuePrj
{
    public class Stack
    {
        protected Node top = null!;
        public int Size { get; private set; }
        public void Push(int data)
        {
            Node newNode = new Node(data);

            newNode.Next = top;
            top = newNode;
            Size++;
        }

        public int Pop()
        {
            if (IsEmpty())
                throw new NullReferenceException("Stack is Empty from the pop");

            int data = top.Data;
            top = top.Next;
            Size--;
            return data;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new NullReferenceException("Stack is Empty from the peek");

            return top.Data;
        }

        public bool IsEmpty() => top is null;

        public override string ToString()
        {

            List<string> result = new() {"Top"};
            Node pointer = top;
            if (IsEmpty())
            {
                result.Add("Null");
            }
            while (pointer != null)
            {
                result.Add(pointer.Data.ToString());
                pointer = pointer.Next;
            }
            return string.Join(" -> ", result);
        }
    }
}
