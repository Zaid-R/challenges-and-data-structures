
namespace StackAndQueuePrj
{
    public class StackWithDeleteMiddle : Stack
    {
        public void DeleteMiddle()
        {
            if (IsEmpty())
            {
                throw new NullReferenceException("Stack is empty, nothing to delete");
            }

            int middleIndex = Size / 2;
            
            Stack tempStack = new Stack();

            // Pop elements until we reach the middle
            for (int i = 0; i < middleIndex; i++)
            {
                tempStack.Push(Pop());
            }

            // Remove the middle element
            Pop();

            // Push the held elements back onto the stack
            while (!tempStack.IsEmpty())
            {
                Push(tempStack.Pop());
            }
        }
    }
}
