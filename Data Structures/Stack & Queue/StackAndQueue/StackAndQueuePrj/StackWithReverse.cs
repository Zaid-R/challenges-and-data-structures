
namespace StackAndQueuePrj
{
    public class StackWithReverse : Stack
    {
        private Queue queue = new ();
        public void ReverseStack()
        {
            if (IsEmpty())
            {
                return;
            }

            // Dequeue all elements from stack to queue
            while (!IsEmpty())
            {
                queue.Enqueue(Pop());
            }

            // Enqueue all elements back to stack from queue
            while (!queue.IsEmpty())
            {
                Push(queue.Dequeue());
            }
        }
    }
}
