namespace LinkedListProject
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            
             var list = new LinkedList(new Node(5));
            list.Remove(5);
            Console.WriteLine("list.head: "+ list.Head);
            Console.WriteLine(list.PrintList());

            int[] values = { 1, 2, 3, 2, 4, 3 };
            //int[] values = { 5, 20, 20, 10, 5, 10 };
            //5 , 20 , 20 , 10 , 5 , 10
            //int[] values = { 7,7,7,7 };
            foreach (int value in values)
            {
                list.Add(value);
            }


            Console.WriteLine("after using RemoveDuplicate():");
            list.RemoveDuplicate();
            Console.WriteLine(list.PrintList()); ;
            Console.WriteLine("list contains(21): "+list.Includes(21));

            Console.WriteLine("list contains(20): " + list.Includes(20));
            Console.WriteLine("list.head: " + list.Head);
            Console.WriteLine(list.PrintList());

            list.Remove(30);
            //Console.WriteLine(list.Tail.value);
            Console.WriteLine(list.PrintList());
        }
    }
}
