namespace LinkedListProject
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            
             var list = new LinkedList();

            int[] values = { 10, 20,30 };
            //int[] values = { 5, 20, 20, 10, 5, 10 };
            //5 , 20 , 20 , 10 , 5 , 10
            //int[] values = { 7,7,7,7 };
            
            list.addArray(values);
            var list2 = new LinkedList();

            values = new int[]{ 5, 15,25,35 };
            list2.addArray(values);

            var mergedList = LinkedList.MergeSortedLists(list, list2);
            Console.WriteLine("List 1: "+list.PrintList());
            Console.WriteLine("List 2: " + list2.PrintList());
            Console.WriteLine("Merged List: "+mergedList.PrintList());
            Console.ReadKey();
            //Console.WriteLine("after using RemoveDuplicate():");
            //list.RemoveDuplicate();
            //Console.WriteLine(list.PrintList()); ;
            //Console.WriteLine("list contains(21): "+list.Includes(21));

            //Console.WriteLine("list contains(20): " + list.Includes(20));
            //Console.WriteLine("list.head: " + list.Head);
            //Console.WriteLine(list.PrintList());

            //list.Remove(30);
            ////Console.WriteLine(list.Tail.value);
            //Console.WriteLine(list.PrintList());
        }
    }
}
