using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ApplyForLicenece
{

    //Creating Custom Exception using inheritance, where Exception is the base class
    class CheckEligibiltyException : Exception
    {
        //public string UserName { get; set; }
        //public int UserAge { get; set; }


        //Using inheritance concept to inherit the base class Exception
        public CheckEligibiltyException() : base()
        {

        }
        //public CheckEligibiltyException(string name, int age)
        //{
        //    UserName = name;
        //    UserAge = age;
        //}

        //Direct method to check age eligibity

        public static void AgeEligibity(int age)
        {
            if (age < 18 || age > 60)
            {
                throw new CheckEligibiltyException();
            }
            else
            {
                Console.WriteLine($"You are Eligible to Apply for Licenece and Your Age is: {age}");
            }
        }
        //Main Method
        static void Main()
        {
            Console.WriteLine("************Welcome To The Licenece Portal***********");
            Console.WriteLine("Please Enter Your Name As Per Aadhar Card:");
            string name = Console.ReadLine();
            try
            {
                Console.WriteLine("Please Enter Your Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                AgeEligibity(age);  //this is method to check age eligibility
                Console.WriteLine("You Have Successfully Completed Applying for Licence");
            }
            catch (CheckEligibiltyException ex)
            {
                Console.WriteLine("Please Enter The Valid Age(18 to 60) only......");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Server Down ", ex.Message);
            }

            try
            {
                Console.WriteLine("Please Enter Your Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                AgeEligibity(age);
                Console.WriteLine("You Have Successfully Completed Applying for Licence");

            }
            catch (CheckEligibiltyException ex)
            {
                Console.WriteLine("Please Enter The Valid Age(18 to 60) only......");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Server Down ", ex.Message);
            }


            //Console.WriteLine($"You Details are " +
            //    $"Name: {name}" +
            //    $"Age: {age}");
        }

        }
    }
