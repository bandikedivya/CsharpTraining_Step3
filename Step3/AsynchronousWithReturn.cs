using System;

using System.Threading.Tasks;

namespace EmpireRestuarant
{
    class TablesOnRestuarant
    {
        public static async Task<string> Table1Async()
        {
            Console.WriteLine("Ordering Food From Menu");
            await Task.Delay(5000);
            return $"";
        }
    }
     

    class CookingChef
    {

    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("*****************Welcome To Empire Restuarant****************");
            Console.WriteLine("******🍽️🍴 Menu *******");
            Console.WriteLine($"1.🥦 Veg  \n" + "2. 🍗 Non Veg \n" + "3. 🍛🥦 Veg Curry \n" + "4. 🍛🍗 Non Veg Curry \n" );
            int input1 = int.Parse( Console.ReadLine() );

        }
    }
}
