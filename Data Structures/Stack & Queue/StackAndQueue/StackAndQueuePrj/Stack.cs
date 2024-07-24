
namespace StackAndQueuePrj
{
    public class Stack
    {
        private Node top = null!;

        public void Push(int data)
        {
            Node newNode = new Node(data);

            newNode.Next = top;
            top = newNode;
        }

        public int Pop()
        {
            if (IsEmpty())
                throw new NullReferenceException("Stack is Empty from the pop");
            
            int data = top.Data;
            top = top.Next;
            return data;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new NullReferenceException("Stack is Empty from the peek");

            return top.Data;
        }

        public bool IsEmpty()
        {
            return top is null;
        }

    }
}
