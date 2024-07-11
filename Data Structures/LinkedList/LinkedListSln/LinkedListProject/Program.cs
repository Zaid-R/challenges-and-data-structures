namespace LinkedListProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList list = new LinkedList(new Node(5));
            list.Remove(5);
            Console.WriteLine("list.head: "+ list.head);
            Console.WriteLine(list.PrintList());
            
            int[] values = { 10, 20, 30 };
            foreach (int value in values)
            {
                list.Add(value);
            }

            Console.WriteLine("list contains(21): "+list.Includes(21));

            Console.WriteLine("list contains(20): " + list.Includes(20));
            Console.WriteLine("list.head: " + list.head);
            Console.WriteLine(list.PrintList());

            list.Remove(30);
            Console.WriteLine(list.tail.value);
            Console.WriteLine(list.PrintList());
        }
    }
}
