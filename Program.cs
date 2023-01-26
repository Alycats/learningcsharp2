namespace learningcsharp2;
class Program //Write a C# program that takes four numbers as input to calculate and print the average  
{
    static void Main(string[] args)
    {
        double firstvariable = 5;
        double secondvariable = 6;
        double thirdvariable = 7;
        double forthvariable = 8;

        Console.Write("Enter the first number: ");
        firstvariable = Convert.ToDouble( Console.ReadLine() );

        Console.Write("Enter the second number: ");
        secondvariable = Convert.ToDouble( Console.ReadLine() );

        Console.Write("Enter the third number: ");
        thirdvariable = Convert.ToDouble( Console.ReadLine() );

        Console.Write("Enter the forth number: ");
        forthvariable = Convert.ToDouble( Console.ReadLine() );

        Console.WriteLine($" The average of {firstvariable} , {secondvariable} , {thirdvariable} , {forthvariable} = {(firstvariable * secondvariable * thirdvariable * forthvariable)/4}");

        Console.ReadKey(true);
    }
}
