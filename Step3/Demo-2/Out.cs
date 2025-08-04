using System;
/// <summary>
/// .......................USING REF..................
/// return multiple output from a function.
/// The REF keywords in C# is  used for passing the arguments to a method as a reference type.
/// By default, arguments are passed to a method by value.
/// </summary>

class UsingOut
{
    /// <summary>
    /// using out:
    /// That means using out, we are also getting the updated values from the Math function.
    /// **********NOTE:****************
    /// you need to remember is when you want multiple outputs from a function, then you need to use the ref and out parameters in C#.
    /// 
    /// </summary>
    public static void Main()
    {
        //declare the variables
        int addition;
        int subtraction;
        int multiplication;
        int division;
        Math(20, 10, out addition, out subtraction, out multiplication, out division);
        Console.WriteLine("the addition is" + addition);
        Console.WriteLine("the subtraction is" + subtraction);
        Console.WriteLine("the multiplication is" + multiplication);
        Console.WriteLine("the division is" + division);
        Console.ReadLine();


    }
    //Here, we are passing the parameter are value types. That means int, float, Boolean, etc. are used to create value-type variables
    public static void Math(int Number1, int Number2, out int addition, out int subtraction, out int multiplication, out int division)
    {

        //updating the values 
        addition = Number1 + Number2;
        subtraction = Number1 - Number2;
        multiplication = Number1 * Number2;
        division = Number1 / Number2;

    }
}
