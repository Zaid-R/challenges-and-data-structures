namespace StackAndQueuePrj
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(7);
            stack.DeleteMiddle();
            Console.WriteLine(stack); // Stack: Top -> 5 -> 8 -> 14 -> 7

        }
    }
}
