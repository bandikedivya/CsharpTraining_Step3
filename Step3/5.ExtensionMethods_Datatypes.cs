using System;

namespace ExtensionMethods1
{
    public static class StringExtensions
    {
        public static int WordCount(this string input)
        {
            string[] wordcount = input.Split(' ');
            int length = wordcount.Length;
            return length;
        }
    }




    class Program
    {


        static void Main()
        {
            string str = "Hi, I am Divya, Today I am trying wordcounting";
            int length = str.WordCount();
            Console.WriteLine($"The wordcount of Sentence1: \"{str}\" is: {length}");



            string str1 = "I am trying for another sentence";
            int length1 = str1.WordCount();
            Console.WriteLine($"The WordCount of Sentence2: \"{str1}\" is: {length1}");

            string statement = "I am Swapna, From Kadapa";
            int length2 = statement.WordCount();
            Console.WriteLine($"The Total WordCount for Statement: \"{statement}\" is: {length2}");



            //General way to count length of string
            //int wordcount = (str.Split(' ').Length);
            //Console.WriteLine(wordcount);



        }
    }
}
