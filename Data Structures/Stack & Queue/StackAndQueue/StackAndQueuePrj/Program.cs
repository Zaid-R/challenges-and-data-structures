namespace StackAndQueuePrj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new();
            Console.WriteLine("Stack");
            stack.Push(10);
            stack.Push(12);
            stack.Push(5);  
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.IsEmpty());

            Console.WriteLine("============\nQueue");
            
            Queue queue = new ();
            queue.Enqueue(10);
            queue.Enqueue(12);
            queue.Enqueue(5);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.IsEmpty());
            Console.ReadKey();
        }
    }
}
