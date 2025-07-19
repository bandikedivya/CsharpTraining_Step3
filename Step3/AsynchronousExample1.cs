using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousExample1
{
    class CollegeFeeCounter
    {
        public static async Task Student1Process(string name, string rollno)
        {
            Console.WriteLine($"{name} is the first peron in the Queue and now ready to pay the fee....");
            var starttime = DateTime.Now;
            Console.WriteLine($"{name} started filling form at the counter");
            await Task.Delay(4000);
            Console.WriteLine($"{name} completed filling form and started paying amount in the counter");


            var endtime = DateTime.Now;
            var calculatestudent1time = starttime - endtime;
            Console.WriteLine($"Time Taken for {name} to Complete Fee Payment is: {calculatestudent1time.TotalMilliseconds}");
        }
        public static async Task Student2Process(string name, string rollno)
        {
           // Console.WriteLine($"{name} is the next peron in the Queue and now ready to pay the fee....");
            var starttime = DateTime.Now;
            Console.WriteLine($"{name} collecting form and started filling form at the counter");
            await Task.Delay(5000);
            Console.WriteLine($"{name} completed filling form and started paying amount in the counter");
            var endtime = DateTime.Now;
            var calculatestudent2time = starttime - endtime;
            Console.WriteLine($"Time Taken for {name} to Complete Fee Payment is: {calculatestudent2time}");



        }

        public static async Task Student3Process(string name, string rollno)
        {
            //Console.WriteLine($"{name} is the next peron in the Queue and now ready to pay the fee....");
            var starttime = DateTime.Now;
            Console.WriteLine($"{name} collecting form and started filling form at the counter");
            await Task.Delay(5000);
            Console.WriteLine($"{name} completed filling form and started paying amount in the counter");
            var endtime = DateTime.Now;
            var calculatestudent2time = starttime - endtime;
            Console.WriteLine($"Time Taken for {name} to Complete Fee Payment is: {calculatestudent2time}");

        }

        class EmployeeInCounter
        {
            public static async Task CounterEmployeeWork()
            {
                Console.WriteLine("Asynchronous (Parallel Works) - Running All Tasks Simultaneously");
                var startTime = DateTime.Now;
                Task student1 = CollegeFeeCounter.Student1Process("Cam", "18781A0512");
                Console.WriteLine("Student 2 is next person in the Queue to Pay The Fee");
                Task student2 = CollegeFeeCounter.Student2Process("Martin", "18781A0511");
                Console.WriteLine("Student 3 is the last person in the Queue to Pay The Fee");
                Task student3 = CollegeFeeCounter.Student3Process("Jermaiah", "18781A0510");

                //await Task.WhenAll(student1,student2, student3);
                Task Alltasks= Task.WhenAll(student1, student2, student3);
                await Alltasks;
                var endTime = DateTime.Now;
                var TotalTimeToCompleteAllPayments = endTime - startTime;
                Console.WriteLine($"Completed All Students Payments and Time Taken To Complete All Payments Is: {TotalTimeToCompleteAllPayments}");
            }

        }

        class Program
        {
            public static async Task Main()
            {
                await EmployeeInCounter.CounterEmployeeWork();
            }
        }
    }
}