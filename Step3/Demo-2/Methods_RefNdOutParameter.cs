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

            //It will check the seat/sleaper(value) by the number(key)
            Predicate<string> seatcheck = (string seattype) =>
            {
                Dictionary<int, string> Redbus = new Dictionary<int, string>
                {
                    {1, "Seater" },
                    {2, "Seater" },
                    {3, "Sleeper" },
                    {4, "Sleeper" }
                };
                if (int.TryParse(seattype, out int seatkey)) // Built-in/Predefined Method
                {
                    if (Redbus.TryGetValue(seatkey, out string seatname)) // Built-in/Predefined Method
                    {
                        return true;
                    }

                }
                return false;
            };

            Console.WriteLine("Please Enter the Seat Number to check Availability");
            string input1 = Console.ReadLine();
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
            //id += 1878507; // Throws compile-time error, as id is not assigned. 
            id = 1878507;
            name = "Olivia";
            status = true;

        }
    }
}


