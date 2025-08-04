using System;

class Methods_Three
{
    static void Main()
    {

        var startTime = DateTime.Now;
        int number1 = 0;
        bool status1 = false;
        string eName1 = null;

        //string.Format(${ })
        Console.WriteLine("Before calling ref method {0} ,{1} , {2},", number1, status1, eName1);

        Methods_Three.RefParameterValues(ref number1, ref status1, ref eName1);

        //Console.WriteLine(number1);  // 10
        Console.WriteLine($"After calling ref method is {number1}, {status1}, {eName1}");

        int number2;
        bool status2;
        string eName2;
        //Console.WriteLine($"Before calling out method is {number2}, {status2}, {eName2}");

        Methods_Three.OutParameterValues(out number2, out status2, out eName2);

        Console.WriteLine($"After calling out method is {number2}, {status2}, {eName2}");


        //TryParse

        //Methods_Three.OutParameterValues()

        //int.TryParse

        int number = 0;
        bool IsSuccess;
        string input = "10GB";

        Methods_Three.MTryParseInt(input, ref number, out IsSuccess);

        if (IsSuccess)
        {
            Console.WriteLine("Good. i have converted the your input");
        }
        else
        {
            Console.WriteLine("Sorry . Please check your input again");
        }


        var endTime = DateTime.Now;
        Console.WriteLine(endTime - startTime);

    }

    static void RefParameterValues(ref int id, ref bool status, ref string ename)
    {
        //id = 10;
        id += 10;
        status = true;
        ename = "John";
    }

    static void OutParameterValues(out int id, out bool status, out string ename)
    {
        id = 20;
        //id += 10;
        status = true;
        ename = "Robert";
    }

    static void MTryParseInt(string input, ref int number, out bool isSuccess)
    {
        bool output = int.TryParse(input, out number);

        if (output)
        {
            isSuccess = true;
        }
        else
        {
            number = 20;
            isSuccess = false;
        }
    }
}
