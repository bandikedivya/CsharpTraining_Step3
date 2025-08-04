using System;

using System.Threading.Tasks;

namespace EmpireRestuarant
{
    class TablesOnRestuarant
    {
        public static async Task<string> Table1Async()
        {

            Console.WriteLine("[Table 1] Ordering Food From Menu");

            Console.WriteLine("[Table 1]  Waiting For The Food");
            await Task.Delay(10000);  //10 secs


            return $"[Table 1] Completed Eating Food and waiting to pay the amount";
        }
        public static async Task<string> Table2Async()
        {

            Console.WriteLine("[Table 2] Ordering Food From Menu");

            Console.WriteLine("[Table 2] Waiting For The Food");
            await Task.Delay(10000);  //10 secs


            return $"[Table 2] Completed Eating Food and waiting to pay the amount";
        }
        public static async Task<string> Table3Async()
        {

            Console.WriteLine("[Table 3] Ordering Food From Menu");

            Console.WriteLine("[Table 3] Waiting For The Food");
            await Task.Delay(10000);  //10 secs

            return $"[Table 3] Completed Eating Food and waiting to pay the amount";
        }
    }


    class CookingChef
    {
        public static async Task CookingProcessTable1()
        {
            //Table 1 Food Making
            Console.WriteLine("Received Order From Table 1");
            var foodstarttime1 = DateTime.Now;
            Console.WriteLine("Started Making Food For Table 1");
            await Task.Delay(10000);
            Console.WriteLine("Table 1 Food Is Ready and Server is Ready To Pick The Food For Table 1");
            var foodendtime1 = DateTime.Now;
            var Totaltime1 = foodendtime1 - foodstarttime1;
            Console.WriteLine($"Time Taken To Complete Cooking Food For Table 1 is : {Totaltime1}");
        }


        //Table 2 Food Making
        public static async Task CookingProcessTable2()
        {

            Console.WriteLine("Received Order From Table2");
            var foodstarttime2 = DateTime.Now;
            Console.WriteLine("Started Making Food For Table2");
            await Task.Delay(10000);
            Console.WriteLine("Table 2 Food Is Ready and Server is Ready To Pick The Food For Table 2");
            var foodendtime2 = DateTime.Now;
            var Totaltime2 = foodendtime2 - foodstarttime2;
            Console.WriteLine($"Time Taken To Complete Cooking Food For Table 2 is : {Totaltime2}");
        }


        //Table 3 Food Making
        public static async Task CookingProcessTable3()
        {
            Console.WriteLine("Received Order From Table 3");
            var foodstarttime3 = DateTime.Now;
            Console.WriteLine("Started Making Food For Table 3");
            await Task.Delay(10000);
            Console.WriteLine("Table 3 Food Is Ready and Server is Ready To Pick The Food For Table 3");
            var foodendtime3 = DateTime.Now;
            var Totaltime3 = foodendtime3 - foodstarttime3;
            Console.WriteLine($"Time Taken To Complete Cooking Food For Table 3 is : {Totaltime3}");
        }

    }
    class Server
    {
        public static async Task ServingFoodTable1()
        {
            Console.WriteLine("Picked Food For Table 1");
            await Task.Delay(5000);
            Console.WriteLine("Serving Food For Table 1");
        }
        public static async Task ServingFoodTable2()
        {
            Console.WriteLine("Picked Food For Table 2");
            await Task.Delay(5000);
            Console.WriteLine("Serving Food For Table 2");
        }

        public static async Task ServingFoodTable3()
        {
            Console.WriteLine("Picked Food For Table 3");
            await Task.Delay(5000);
            Console.WriteLine("Serving Food For Table 3");
        }
    }
    class Program
    {
        static async Task Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("*****************Welcome To Empire Restuarant****************");
            Console.WriteLine("Enter Your Table Number: ");
            int choice1 = int.Parse(Console.ReadLine());
            switch (choice1)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    //Console.WriteLine("Enter Your Table Number: ");
                    
                    break;

                default:
                    Console.WriteLine("Sorry, I can only print tables 1 to 5.");
                    break;
            }
            Console.WriteLine("******🍽️🍴 Menu *******");
            Console.WriteLine($"1.🥦 Veg  \n" + "2. 🍗 Non Veg \n" + "3. 🍛🥦 Veg Curry \n" + "4. 🍛🍗 Non Veg Curry \n");
            int input1 = int.Parse(Console.ReadLine());




            //Table 1
            Task<string> Table1 = TablesOnRestuarant.Table1Async();
            await Table1;
            var StartTable1 = DateTime.Now;
            Task CookTable1 = CookingChef.CookingProcessTable1();
            await CookTable1;

            Task ServingTable1 = Server.ServingFoodTable1();
            await ServingTable1;
            var ENDTable1 = DateTime.Now;
            var TotalTime1 = DateTime.Now - StartTable1;
            Console.WriteLine("[Table 1] Food Arrived!!, Started Eating Food");
            Console.WriteLine($"Total Time Taken to Arrive Food For Table1 is: {TotalTime1.Milliseconds}  secs");

            Console.WriteLine("\n");
            Console.WriteLine("*****************Welcome To Empire Restuarant****************");
            Console.WriteLine("Enter Your Table Number: ");
            int tableinput2 = int.Parse(Console.ReadLine());
            Console.WriteLine("******🍽️🍴 Menu *******");
            Console.WriteLine($"1.🥦 Veg  \n" + "2. 🍗 Non Veg \n" + "3. 🍛🥦 Veg Curry \n" + "4. 🍛🍗 Non Veg Curry \n");
            int input2 = int.Parse(Console.ReadLine());


            //Table 2
            Task<string> Table2 = TablesOnRestuarant.Table2Async();
            await Table2;
            var StartTable2 = DateTime.Now;
            Task CookTable2 = CookingChef.CookingProcessTable2();
            await CookTable2;

            Task ServingTable2 = Server.ServingFoodTable2();
            await ServingTable2;
            var ENDTable2 = DateTime.Now;
            var TotalTime2 = DateTime.Now - StartTable2;
            Console.WriteLine("[Table 2] Food Arrived!!, Started Eating Food");
            Console.WriteLine($"Total Time Taken to Arrive Food For Table2 is: {TotalTime2.Milliseconds} secs");


            Console.WriteLine("\n");
            Console.WriteLine("*****************Welcome To Empire Restuarant****************");
            Console.WriteLine("Enter Your Table Number: ");
            int tableinput3 = int.Parse(Console.ReadLine());
            Console.WriteLine("******🍽️🍴 Menu *******");
            Console.WriteLine($"1.🥦 Veg  \n" + "2. 🍗 Non Veg \n" + "3. 🍛🥦 Veg Curry \n" + "4. 🍛🍗 Non Veg Curry \n");
            int input3 = int.Parse(Console.ReadLine());

            //Table 3
            Task<string> Table3 = TablesOnRestuarant.Table3Async();
            await Table3;
            var StartTable3 = DateTime.Now;
            Task CookTable3 = CookingChef.CookingProcessTable3();
            await CookTable3;

            Task ServingTable3 = Server.ServingFoodTable3();
            await ServingTable3;

            var ENDTable3 = DateTime.Now;
            var TotalTime3 = DateTime.Now - StartTable3;
            Console.WriteLine("[Table 3] Food Arrived!!, Started Eating Food");
            Console.WriteLine($"Total Time Taken to Arrive Food For Table3 is: {TotalTime3.Milliseconds} secs");



            string[] AllTables = await Task.WhenAll(Table1, Table2, Table3);
            foreach (string table in AllTables)
            {
                Console.WriteLine(table);
            }

            await Task.WhenAll(CookTable1, CookTable2, CookTable3);


            await Task.WhenAll(ServingTable1, ServingTable2, ServingTable3);
        }
    }
}
