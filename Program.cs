namespace learningcsharp2;
class Program //Write a C# program to print the sum of two numbers 
{
    static void Main(string[] args)
    {
        int firstvariable = 7;
        int secondvariable = 12;
        Console.Write("Enter the first number: ");
        firstvariable = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Enter the second number: ");
        secondvariable = Convert.ToInt32( Console.ReadLine() );

        Console.WriteLine($"The sum of {firstvariable} and {secondvariable} is {firstvariable + secondvariable}");
        Console.WriteLine($" {firstvariable} + {secondvariable} = {firstvariable + secondvariable}");
        
        Console.ReadKey(true);
    }
}
