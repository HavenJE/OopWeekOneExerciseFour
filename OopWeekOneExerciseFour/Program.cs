
// Exercise 4
// Create a program named Reverse3 whose Main() method declares three integers names firstInt, middleInt and lastInt. Assign values to the variables,
// display them and then pass them to a method that accepts them as reference variables.
// The method places the first value in the lastInt, and places the last value in the firstInt variable.
// In the Main() method, display the three variables again demonstrating that their positions have been reversed.

class Reverse3
{
    static void Main()
    {
        // Declare and assign values for 3 variables: firstInt, middleInt, and lastInt
        int firstInt = 23;
        int middleInt = 45;
        int lastInt = 67;

        // display the variables 
        Console.WriteLine("{0}, {1} , {2}", firstInt, middleInt, lastInt);

        // The method places the first value in the lastInt, and places the last value in the firstInt variable
        Reverse(ref firstInt, ref middleInt, ref lastInt);
        
        // display the Reverse() method 
        Console.WriteLine("{0}, {1} , {2}", firstInt, middleInt, lastInt);
    }

    public static void Reverse(ref int a, ref int b, ref int c)
    {
        int temp = a; 
        a = c; 
        c = temp;
    }
}