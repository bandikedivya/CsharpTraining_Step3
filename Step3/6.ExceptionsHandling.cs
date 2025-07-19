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
using System.Runtime.InteropServices;

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
            finally
            {
                Console.WriteLine("This NullException has occured");
            }
        }
        public static void Exception2()
        {
            try
            {
                int.Parse("ConverttoInt");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Exception3(string input1, string input2, int firstnumber, int secondnumber)
        {
            try
            {
                int length = input1.Length;
                Console.WriteLine(length);


                int.Parse(input2);

                //int firstnumber = 100;
                //int secondnumber = 0;



                int resultoftwonums  = firstnumber / secondnumber;
                
                

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (DivideByZeroException dx)
            {
                Console.WriteLine("Any number divide by 0 will return NullException");
                Console.WriteLine(dx.Message);

            }
        }

        public static void DivideByZeroMethod()
        {
            int number1 = 15;
            int number2 = 0;
            try
            {
                int result = number1 / number2;
            }
            catch (DivideByZeroException dx)
            {
                Console.WriteLine("Any number divide by 0 will return NullException");
                Console.WriteLine(dx.Message);

            }
        }


        public static void AgeMethod()
        {
            try
            {
                int age = -15;

                if (age > 0)
                {
                    Console.WriteLine("You are Eligible to Apply And Your Age is:" +" "+ age);
                }
                else
                {
                    throw new ArgumentException("Age cannot be negative");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        public static void Main()
        {
            //Exceptions.Exception1(null);

            //Exceptions.Exception2();



              Exceptions.Exception3("Divya", "Divyabandike", 100,0);

            // Exceptions.DivideByZeroMethod(100, 0);
           // Exceptions.DivideByZeroMethod();


            //Console.WriteLine("Please Enter Your Age:");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Exceptions.AgeMethod();

            Console.WriteLine("Even There are Errors in code, This Line should Print");
        }
    }
}