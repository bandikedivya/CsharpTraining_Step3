//Syntax:
//try
//{
//    // Code that may throw an exception
//}
//catch (Exception ex)
//{
//    // Handle the exception
//    Console.WriteLine($"An error occurred: {ex.Message}");
//}
//finally
//{

//}
using System;

namespace ExceptionHandling
{
    class Exceptions
    {
        public static void Exception1(string input)
        {
            try
            {
                int length = input.Length;
                Console.WriteLine(length);
            }
            catch (Exception ex) 
            {
                //Console.WriteLine(ex.Message); //We can custom the error message here
                Console.WriteLine("NullException");
            }
        }
        //public static void Exception2(string input1)
        //{
        //    try
        //    {

        //    }
        //}
        static void Main()
        {
            Exceptions.Exception1(null);
        }
    }
}