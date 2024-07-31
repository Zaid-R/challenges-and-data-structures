
namespace StackAndQueuePrj
{
    public class StackWithReverse : Stack
    {
        private Queue queue = new ();
        private Stack stack = new ();
        public void ReverseStack()
        {
            if (stack.IsEmpty())
            {
                return;
            }

            // Dequeue all elements from stack to queue
            while (!stack.IsEmpty())
            {
                queue.Enqueue(stack.Pop());
            }

            // Enqueue all elements back to stack from queue
            while (!queue.IsEmpty())
            {
                stack.Push(queue.Dequeue());
            }
        }

        public new void Push(int value) => stack.Push(value);

        public override string ToString() => stack.ToString();
    }
}
