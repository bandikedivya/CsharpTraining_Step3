using System;

// Top 5 Extension Method , Override methods

//extenison method similar to normal method

//you can return void or non-void

//you can pass the parameter



namespace ExtensionMethods
{
    public class BookingSystem
    {
        public string BookApplication { get; set; }
        public void BookAuto(string customername)
        {
            Console.WriteLine($"{customername} has Booked Auto 🛺 in {BookApplication}");
        }
    }

    //Extension Method, It must contain only static members
    public static class BookCab
    {
        //Extension method without parameter
        public static void BookingCab(this BookingSystem customer)
        {
            Console.WriteLine($"Rachana has booked Cab 🚖 in {customer.BookApplication}");
        }

        //Extension method with parameters

        public static void BookingCabXL(this BookingSystem customer, string customer1)
        {
            Console.WriteLine($"{customer1} has Booked CabXL 🚕 in {customer.BookApplication}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;  //To add emojies in code

            //To call BookAuto, which is non-static method, created instance. Through instance, I have called BookAuto Method which is non-static method
            BookingSystem customer = new BookingSystem() { BookApplication = "Uber" };
            customer.BookAuto("Rachana");

            //Through the instance, I have called these extension methods
            customer.BookingCab();
            customer.BookingCabXL("Rachana BD");
        }
    }
}
