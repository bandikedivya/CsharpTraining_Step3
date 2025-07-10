using System;

namespace MathCalculation
{

    class Program
    {
        static string[] ArrayDivision(int[] numbers)
        {
            string[] result = new string[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 5 == 0)
                {
                    Console.WriteLine($"{numbers[i]} is divisible by 5");
                }
                else
                {
                    Console.WriteLine($"{numbers[i]} is not divisible by 5");
                }
            }

            return result;

        }


        //static string[] ArrayMultipe(int[] numbers1)
        //{
        //    foreach (int number in numbers1)
        //    {
        //        while()
        //    }
        //    return null;
        //}

        static void Main()
        {
            int[] numbers = { 5, 6, 9, 10, 15, 19, 20, 25 };
            Program.ArrayDivision(numbers);
            //string[] output = Program.ArrayDivision(numbers);
            // Console.WriteLine(output);
            //foreach (string result in output)
            //{
            //    Console.WriteLine(result);
            //}
            //int[] number1 = { 2, 3, 4, 5, 6, 7, 8, 9, };
        }
    }
}













//Methods revisions
//using System;

//namespace MathProgram
//{

//Array in Step1

//string[] results = new string[3]  
// for loop from step1
// 10 is even
// 15 is odd
// 20 is even
// 25 is odd
// 30 is odd
//    class Program
//    {
//        //5
//        static string[] ProcesssArray(int[] numbers)
//        {
//            // Create a string array to store results
//            string[] results = new string[numbers.Length];

//            for (int i = 0; i < numbers.Length; i++)
//            {
//                if (numbers[i] % 2 == 0)
//                {
//                    results[i] = $"{numbers[i]} is Even";
//                }
//                else
//                {
//                    results[i] = $"{numbers[i]} is Odd";
//                }
//            }
//            return results;
//        }


//        static void Main()
//        {

//            int[] numbers = { 10, 15, 20, 25, 30 };   //Input Array

//            string[] output = Program.ProcesssArray(numbers);

//            Console.WriteLine(output);
//            foreach (string result in output)
//            {
//                Console.WriteLine(result);
//            }

//        }



//    }


//}