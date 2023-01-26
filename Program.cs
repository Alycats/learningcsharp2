namespace learningcsharp2;
class Program //Write a C# program to print the sum of two numbers 
{
    static void Main(string[] args)
    {
        int firstvariable = 5;
        int secondvariable = 6;
        Console.Write("Enter the first number: ");
        firstvariable = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Enter the second number: ");
        secondvariable = Convert.ToInt32( Console.ReadLine() );

        Console.WriteLine($" {secondvariable} {firstvariable}");

        Console.ReadKey(true);
    }
}
