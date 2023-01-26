namespace learningcsharp2;
class Program //Write a C# program  that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit
{
    static void Main(string[] args)
    {
        double firstvariable = 5;
   

        Console.Write("Enter the first number: ");
        firstvariable = Convert.ToDouble( Console.ReadLine() );


        Console.WriteLine($"{firstvariable}{firstvariable}{firstvariable}{firstvariable} ");
        Console.WriteLine($"{firstvariable}  {firstvariable} ");
        Console.WriteLine($"{firstvariable}  {firstvariable} ");
        Console.WriteLine($"{firstvariable}  {firstvariable} ");
        Console.WriteLine($"{firstvariable}{firstvariable}{firstvariable}{firstvariable} ");

        Console.ReadKey(true);
    }
}
