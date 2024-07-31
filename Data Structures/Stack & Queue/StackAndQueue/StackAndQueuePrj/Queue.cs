
namespace StackAndQueuePrj
{
    public class Queue
    {
        private Node front = null!;
        private Node back = null!;

        public bool IsEmpty() => front is null;

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);

            if (IsEmpty())
            {
                front = back = newNode;
            }
            else
            {
                back.Next = newNode;
                back = newNode;
            }
        }

        public int Dequeue()
        {
            if (IsEmpty())
                throw new NullReferenceException("You're trying to dequeue while queue is empty");

            int value = front.Data;
            front = front.Next;
            return value;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new NullReferenceException("You're trying to get the peek of queue while it's empty");
            return front.Data;
        }
    }
}
