using Method1_Advanced;
using System;
using System.Runtime.Remoting.Messaging;

namespace Method_Advance
{
    class Registration
    {
        public string Name { get; set; }
        public string EmailId { get; set; }
        public int Age { get; set; }

    }
    class RegistrationProcess
    {
        //Single Person Registration
        //public static Registration GetRegistration()   //Type 1 - Method Definition 
        //{
        //    Registration reg1 = new Registration();
        //    {
        //        reg1.Name = "Justin";
        //        reg1.EmailId = "justin@gmail.com";
        //        reg1.Age=20;
        //        return reg1;
        //    }
        //}
        // public static Registration GetRegistration() //Type 2 - Method Definition
        //{

        //    Registration registration = new Registration()
        //    {
        //        Name = "Justin",
        //        EmailId = "justin@gmail.com",
        //        Age = 20
        //    };
        //    return registration;
        //}
        public static Registration GetRegistration1() //Type 3 - Method Definition
        {
            return new Registration()
            {
                Name = "Justin",
                EmailId = "justin@gmail.com",
                Age = 20
            };
        }

        public static Registration UpdateRegistration(Registration registration)
        {
            registration.Name = registration.Name + "  Finn";
            registration.Age = 40;
            registration.EmailId = "finn@hmail.com";
            return registration;
        }

        public static Registration GetRegistration2()  //Used Type 3 -- Method Definition
        {
            return new Registration()
            {
                Name = "Belly",
                EmailId = "belly@gmail.com",
                Age = 19

            };
        }
        //Multiple Persons Registration
        //public static Registration[] GetRegistrations()  //Type 1 --Method Definition
        //{
        //    Registration registration1 = new Registration();
        //    registration1.Name = "Marcus";
        //    registration1.EmailId = "marcus@gmail.com";
        //    registration1.Age = 22;

        //    Registration registration2 = new Registration();
        //    registration2.Name = "Ginny";
        //    registration2.EmailId = "ginny@gmail.com";
        //    registration2.Age = 16;

        //    Registration registration3 = new Registration();
        //    registration3.Name = "Goergia";
        //    registration3.EmailId = "goergia@gmail.com";
        //    registration3.Age = 30;

        //    Registration[] registrations = new Registration[] { registration1, registration2, registration3 };  
        //    return registrations;
        //}

        //public static Registration[] GetRegistration()  //Type 2 --Method Definition
        //{
        //    Registration[] registrations = new Registration[] {
        //        new Registration()
        //        {
        //            Name = "Marcus",
        //            EmailId = "marcus@gmail.com",
        //            Age = 22
        //            },
        //        new Registration() {
        //            Name = "Ginny",
        //            EmailId = "ginny@gmail.com",
        //            Age = 16
        //        },
        //        new Registration() {
        //            Name = "Goergia",
        //            EmailId = "goergia@gmail.com",
        //            Age = 30
        //        },
        //    };
        //    return registrations;
        //}

        public static Registration[] GetRegistrations()
        {
            return new Registration[] {
                new Registration()
                {
                    Name = "Marcus",
                    EmailId = "marcus@gmail.com",
                    Age = 22
                },
                new Registration()
                {
                    Name = "Ginny",
                    EmailId = "ginny@gmail.com",
                    Age = 16
                },
                new Registration()
                {
                    Name = "Goergia",
                    EmailId = "goergia@gmail.com",
                    Age = 30
                },
            };
        }

        public static Registration[] UpdateRegistartions(Registration[] registrations)
        {
            foreach (Registration registration in registrations)
            {
                registration.Age = registration.Age + 4;
            }
            return registrations;
        }



        class Program
        {
            static void Main()
            {
                //Single Person Registration
                // Here Registration(we can use "var" or "Dynamic" keyword instead, we should make sure that data is available) is the main class where I have mentioned properties, singlereg1 is the reference name, RegistrationProcess is the class for method definition and GetRegister() is the Method. 

               
                Console.WriteLine("*************************Total Registered List*************************");
                Registration singlereg1 = RegistrationProcess.GetRegistration1();
                Console.WriteLine($"Name: {singlereg1.Name}, Email id: {singlereg1.EmailId}, Age: {singlereg1.Age}");

                //Here I have used "var" keyword instead Registration
                // Here Registration(we can use "var" or "Dynamic" keyword instead, we should make sure that data is available) is the main class where I have mentioned properties, singlereg1 is the reference name, RegistrationProcess is the class for method definition and GetRegister() is the Method. 
                
                var singlereg2 = RegistrationProcess.GetRegistration2();
                Console.WriteLine($"Name: {singlereg2.Name}, Email id: {singlereg2.EmailId}, Age: {singlereg2.Age}");


                //Updation Calling
                var registrationList = RegistrationProcess.GetRegistrations(); //instance for updation
                foreach (Registration registration in registrationList)
                {
                    Console.WriteLine($"Name: {registration.Name}, Email: {registration.EmailId}, Age: {registration.Age}");
                }

                //In Justin Details, we are updating Age. SO, we should mention justin's details here
                Registration updation = RegistrationProcess.UpdateRegistration(new Registration() //instance
                {
                    Name = "Justin",
                    Age = 20,
                    EmailId = "justin@gmail.com"
                });

                //Updation in list

                Registration updationList = RegistrationProcess.UpdateRegistration(updation);
                

                Registration[] updation2 = RegistrationProcess.UpdateRegistartions(new Registration[] {
                    new Registration()
                {
                    Name = "Marcus",
                    EmailId = "marcus@gmail.com",
                    Age = 22
                },
                new Registration()
                {
                    Name = "Ginny",
                    EmailId = "ginny@gmail.com",
                    Age = 16
                },
                new Registration()
                {
                    Name = "Goergia",
                    EmailId = "goergia@gmail.com",
                    Age = 30
                }
                });


                Registration[] multireg = RegistrationProcess.UpdateRegistartions(registrationList);
                foreach (Registration registration1 in multireg)
                {
                    Console.WriteLine($"Update Registration: {registration1.Name}  updated Age to {registration1.Age}");
                }
             


            }
        }
    }
}