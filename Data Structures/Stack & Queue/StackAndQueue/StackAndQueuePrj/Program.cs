namespace StackAndQueuePrj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack stack = new();
            //Console.WriteLine("Stack");
            //stack.Push(10);
            //stack.Push(12);
            //stack.Push(5);  
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.IsEmpty());

            //Console.WriteLine("============\nQueue");

            //Queue queue = new ();
            //queue.Enqueue(10);
            //queue.Enqueue(12);
            //queue.Enqueue(5);
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Peek());
            //Console.WriteLine(queue.IsEmpty());
            //Console.ReadKey();

            StackWithReverse stack = new StackWithReverse();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Act
            stack.ReverseStack();
            Console.WriteLine(stack);
            StackWithReverse stack2 = new();
            stack2.Push(1);
            stack2.Push(2);
            stack2.Push(3);
            stack2.Push(4);
            stack2.Push(5);

            Console.WriteLine(stack2); // Stack: Top -> 5 -> 4 -> 3 -> 2 -> 1
            stack2.ReverseStack();
            Console.WriteLine(stack2); // Stack: Top -> 1 -> 2 -> 3 -> 4 -> 5

            stack2.Push(6);
            stack2.Push(7);
            Console.WriteLine(stack2); // Stack: Top -> 7 -> 6 -> 1 -> 2 -> 3 -> 4 -> 5
            stack2.ReverseStack();
            Console.WriteLine(stack2);
        }
    }
}
