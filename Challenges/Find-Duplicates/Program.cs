namespace challenges_and_data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 1, 2, 3 };
            int[] arr2 = { 16, 8, 31, 17, 15, 23, 17, 8 };
            int[] arr3 = { 5, 10, 16, 20, 10, 16 };
            Console.WriteLine("arr :{0} result: {1}", String.Join(",", arr1), String.Join(",", FindDuplicates(arr1)));
            Console.WriteLine("arr :{0} result: {1}", String.Join(",", arr2), String.Join(",", FindDuplicates(arr2)));
            Console.WriteLine("arr :{0} result: {1}", String.Join(",", arr3), String.Join(",", FindDuplicates(arr3)));
        }

        static int[] FindDuplicates(int[] arr)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            foreach (int number in arr)
            {
                numbers[number] = numbers.ContainsKey(number) ? numbers[number] + 1 : 1;
            }

            List<int> duplicates = new List<int>();

            foreach (int key in numbers.Keys)
            {
                if (numbers[key] > 1)
                {
                    duplicates.Add(key);
                }
            }
            return duplicates.ToArray();
        }
    }
}
