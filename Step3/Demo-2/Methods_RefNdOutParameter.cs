using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2Student
{

    class RefOutParamaeter
    {
        // Main Entry of the Program

        static void Main()
        {
            int StudId = 10;
            string StudName = null;
            bool IsStudActive = false;

            Console.WriteLine("*************************** Before Ref Method Calling *********************************");
            Console.WriteLine($"\nThe Student Name: {StudName},\nStudentId: {StudId}, \nStudent Attending Classes: {IsStudActive}");


            RefOutParamaeter.RefMethod(ref StudId, ref StudName, ref IsStudActive);

            Console.WriteLine("*************************** After Ref Method Callled *********************************");
            Console.WriteLine($"\nThe Student Name: {StudName},\nStudentId: {StudId}, \nStudent Attending Classes: {IsStudActive}");

            Console.WriteLine();

            int StudId1;
            string StudName1;
            bool IsStudActive1;

            //Console.WriteLine("*************************** Before Out Method Calling *********************************");
            //Console.WriteLine($"\nThe Student Name: {StudName1},\nStudentId: {StudId1}, \nStudent Attending Classes: {StudActive1}");


            RefOutParamaeter.OutMethod(out StudId1, out StudName1, out IsStudActive1);

            Console.WriteLine("*************************** After Out Method Called *********************************");
            Console.WriteLine($"\nThe Student Name: {StudName1},\nStudentId: {StudId1}, \nStudent Attending Classes: {IsStudActive1}");



            Console.WriteLine();

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // It will check the seat/sleaper(value) by the seat number(key)
            // This is a Predicate delegate named seatcheck, which takes a string seattype as input and returns a bool.
            // Inside the lambda, I have created a dictionary Redbus, where interger key(seat numbers) maps to seat type string like "Seater" or "Sleeper".


            Predicate<string> seatcheck = (string seattype) =>
            {
                Dictionary<int, string> Redbus = new Dictionary<int, string>
                {
                    {1, "Seater" },
                    {2, "Seater" },
                    {3, "Sleeper" },
                    {4, "Sleeper" }
                };
                
                //This int.TryParse attempts to parse the input string seattype into a integer seatkey.
                // This returns true if seattype is a valid integer; else returns false.
                // For example, if I enter seattype "3", then seatkey becomes the integer 3.


                if (int.TryParse(seattype, out int seatkey)) // Built-in/Predefined Method
                {
                    // Here, TryGetValue receives the seat number (seatkey) and checks if it exists in the Redbus dictionary.
                    // For example, if seatkey == 3, then seatname = "Sleeper". If the seat number doesn't exists, it returns false.


                    if (Redbus.TryGetValue(seatkey, out string seatname)) // Built-in/Predefined Method
                    {
                        return true;
                    }

                }
                return false;
            };


            Console.WriteLine("Please Enter the Seat Number to check Availability");

            string input1 = Console.ReadLine();

            //Calls the seatcheck predicate delegate. passing in the input string. The result determines availability.

            bool isAvailable1 = seatcheck(input1);
            if (isAvailable1)
            {
                Console.WriteLine("🎉💺 Seater/Sleeper is Available!!");
            }
            else
            {
                Console.WriteLine("⛔💺 Seater/Sleeper is Not Available!!");
            }

        }


        // Ref Method
        public static void RefMethod(ref int id, ref string name, ref bool status)
        {
            id += 1878512;
            name = "Adam";
            status = true;

        }

        // Out Method
        public static void OutMethod(out int id, out string name, out bool status)
        {
            
            id = 1878507;
            id += 1878507; // Throws compile-time error, as id is not assigned. 
            name = "Olivia";
            status = true;

        }
    }
}


