using System;

namespace ReverseWords
{
    public class Program
    {
        public static string ReverseWords(string sentence)
        {
            string[] words = sentence.Split(" ");
            int wordsLength = words.Length;

            string[] reversedWords = new string[words.Length];
            for (int i = wordsLength; i > 0; i--)
            {
                reversedWords[wordsLength - i] = words[i - 1];
            }
            return string.Join(' ', reversedWords);
        }

        static void Main(string[] args)
        {
            string input = "csharp is programming language";
            Console.WriteLine("Input: {0} | output: {1}",input,ReverseWords(input));
        }
    }


}
