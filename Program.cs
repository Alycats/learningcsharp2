namespace learningcsharp2;
class Program //Write a C# program to print the sum of two numbers 
{
    static void Main(string[] args)
    {
        double firstvariable = 7;
        double secondvariable = 12;
        Console.Write("Enter the first number: ");
        firstvariable = Convert.ToDouble( Console.ReadLine() );
        Console.Write("Enter the second number: ");
        secondvariable = Convert.ToDouble( Console.ReadLine() );

        Console.WriteLine($" {firstvariable} / {secondvariable} = {firstvariable / secondvariable}");
        Console.WriteLine($" {firstvariable} + {secondvariable} = {firstvariable + secondvariable}");
        Console.WriteLine($" {firstvariable} - {secondvariable} = {firstvariable - secondvariable}");
        Console.WriteLine($" {firstvariable} * {secondvariable} = {firstvariable * secondvariable}");

        Console.ReadKey(true);
    }
}
