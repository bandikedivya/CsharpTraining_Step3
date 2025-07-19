
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousCalls
{
    class WorkItems
    {
        public static async Task PrepareWordDocumentationAsync()
        {
            var startTime = DateTime.Now;
            await Task.Delay(10000);   // please wait....to telling to the compiler
            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;
            Console.WriteLine($"Completed the Doucumentation Elapsed time: {elapsedTime.Milliseconds} ms.");

        }
    }

    class Trainer
    {
        public static async Task Works()
        {
            Console.WriteLine("Concurrent Works - Running All Tasks Simultaneously");
            Task documentationTask = WorkItems.PrepareWordDocumentationAsync();  // 5 seconds
            Console.WriteLine("Hello World");
            await documentationTask;

        }
    }


    class Program
    {
        static async Task Main()
        {
            await Trainer.Works();
        }
    }
}