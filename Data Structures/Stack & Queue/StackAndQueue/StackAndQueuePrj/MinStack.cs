
namespace StackAndQueuePrj
{
    public class MinStack : Stack
    {
        // Peek() is alternative of Top()

        public int GetMin()
        {
            if (IsEmpty())
                throw new NullReferenceException("Stack is empty");

            Node pointer = top;
            int min = top.Data;
            while (pointer != null)
            {
                if (min > pointer.Data)
                {
                    min = pointer.Data;
                }
                pointer = pointer.Next;
            }
            return min;
        }

        public void PrintStack() => Console.WriteLine( ToString());
    }
}
