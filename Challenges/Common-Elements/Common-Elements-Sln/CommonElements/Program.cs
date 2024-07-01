namespace CommonElements
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" result: {0}", String.Join(",", CommonElements(new int[] { 1, 2, 3, 0 }, new int[] { 2, 3, 4, 9 })));
            Console.WriteLine(" result: {0}", String.Join(",", CommonElements(new int[] { 79, 8, 15 }, new int[] { 23, 79, 8 })));
            Console.WriteLine(" result: {0}", String.Join(",", CommonElements(new int[] { 5, 10, 15, 20 }, new int[] { 10, 15, 25 })));
        }

        public static int[] CommonElements(int[] arr1, int[] arr2)
        {
            List<int> commonNumbers = new List<int>();
            foreach (int number in arr1)
            {
                if (arr2.Contains(number))
                {
                    commonNumbers.Add(number);
                }
            }
            return commonNumbers.ToArray();
        }
    }
}
