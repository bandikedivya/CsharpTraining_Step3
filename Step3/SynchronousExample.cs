using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronousStudentExample
{
    class CollegeFeeCounter
    {

        public static void Student1Process(string name, string rollno)
        {
            Console.WriteLine($"{name} is the first peron in the Queue and now ready to pay the fee....");
            var starttime = DateTime.Now;
            Thread.Sleep(4000);
            Console.WriteLine($"{name} started filling form and paying amount in the counter");


            var endtime = DateTime.Now;
            var calculatestudent1time = starttime - endtime;
            Console.WriteLine($"Time Taken for {name} to Complete Fee Payment is: {calculatestudent1time}");
        }

        public static void Student2Process(string name, string rollno)
        {
            Console.WriteLine($"{name} is the first peron in the Queue and now ready to pay the fee....");
            var starttime = DateTime.Now;
            Thread.Sleep(5000);
            Console.WriteLine($"{name} started filling form and paying amount in the counter");
            var endtime = DateTime.Now;
            var calculatestudent2time = starttime - endtime;
            Console.WriteLine($"Time Taken for {name} to Complete Fee Payment is: {calculatestudent2time}");



        }

        public static void Student3Process(string name, string rollno)
        {
            Console.WriteLine($"{name} is the first peron in the Queue and now ready to pay the fee....");
            var starttime = DateTime.Now;
            Thread.Sleep(5000);
            Console.WriteLine($"{name} started filling form and paying amount in the counter");
            var endtime = DateTime.Now;
            var calculatestudent2time = starttime - endtime;
            Console.WriteLine($"Time Taken for {name} to Complete Fee Payment is: {calculatestudent2time}");

        }



    }

    class Employee
    {
        public static void EmployeeCounter()
        {
            Console.WriteLine("Students In Queue.............");
            var StartTime = DateTime.Now;

            CollegeFeeCounter.Student1Process("Divya", "18781A0512");
            CollegeFeeCounter.Student2Process("Swapna", "18781A0511");
            CollegeFeeCounter.Student3Process("Usha", "18781A0510");


            var EndTime = DateTime.Now;
            var TotalTime = EndTime - StartTime;

            Console.WriteLine($"Total Time Taken to Complete all Students Fee Payment {TotalTime}");
        }
    }

    class Program
    {
        static void Main()
        {



            Employee.EmployeeCounter();
            //Console.WriteLine("Students In Queue.............");
            //var StartTime = DateTime.Now;

            //CollegeFeeCounter.Student1Process("Divya", "18781A0512");
            //CollegeFeeCounter.Student2Process("Swapna", "18781A0511");
            //CollegeFeeCounter.Student3Process("Usha", "18781A0510");
           
            
            //var EndTime = DateTime.Now;
            //var TotalTime = EndTime - StartTime;

            //Console.WriteLine($"Total Time Taken to Complete all Students Fee Payment {TotalTime}");
        }
    }
}
