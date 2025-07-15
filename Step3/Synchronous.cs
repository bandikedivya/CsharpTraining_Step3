using System;
using System.Data.SqlTypes;
using System.Threading;

namespace SynchronousCallsIn
{





    class WorkItems
    {

        //public static void test1()
        //{
        //    var a = 10;
        //    Thread.Sleep(25000); //sleep for 3 seconds

        //    var b = 20;
        //}


        public static void PrepareWordDocumentation()
        {
            var startTime = DateTime.Now;
            //Method which gives the sleep time.
            Thread.Sleep(2000);   //
            //DB - 40000Records
            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;
            Console.WriteLine($"Completed the Doucumentation Elapsed time: {elapsedTime.Milliseconds} ms.");

        }

        public static void PreparePPTsDocumentation()
        {
            var startTime = DateTime.Now;
            //Method which gives the sleep time.
            Thread.Sleep(5000);   //
            //DB - 40000Records
            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;
            Console.WriteLine($"Completed the Doucumentation Elapsed time: {elapsedTime.Milliseconds} ms.");
        }

        public static void PrepareNotesDocumentation()
        {
            var startTime = DateTime.Now;
            //Method which gives the sleep time.
            Thread.Sleep(4000);   //
            //DB - 40000Records
            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;
            Console.WriteLine($"Completed the Doucumentation Elapsed time: {elapsedTime.Milliseconds} ms.");
        }
    }

    class Trainer
    {
        public static void Works()
        {
            Console.WriteLine("Sequential Works - Step By Step");
            var preparationStartTime = DateTime.Now;

            WorkItems.PrepareWordDocumentation();
            WorkItems.PreparePPTsDocumentation();
            WorkItems.PrepareNotesDocumentation();

            var preparationEndTime = DateTime.Now;

            var sequentialElapsedTime = preparationEndTime - preparationStartTime;

            Console.WriteLine($"Sequential downloading completed. Total elapsed time: " +
                $"{sequentialElapsedTime.TotalMilliseconds} ms.");

        }

    }

    class Program
    {
        static void Main()
        {
            Trainer.Works();  // 11 to 12 Secs -> taking time..
        }

    }
}