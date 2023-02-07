namespace learningcsharp2;
class Program //Write a C# program  that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit
{
    static void Main(string[] args)
    {
    numbersameahhhh();
    Console.ReadKey(true);
    }

static void numbersameahhhh()
{
    int num1=0;

    Console.WriteLine("Enter a Number");
    num1=Convert.ToInt32(Console.ReadLine());

    for (int i=0; i<num1; i++)
    {
Console.WriteLine($"{num1}  {num1}");
    }

}






static void lineslots()
{
    double firstvariable = 5;

        Console.Write("Enter the first number: ");
        firstvariable = Convert.ToDouble( Console.ReadLine() );
        
         Console.WriteLine($"{firstvariable}{firstvariable}{firstvariable}{firstvariable} ");
         Console.WriteLine($"{firstvariable}  {firstvariable} ");
         Console.WriteLine($"{firstvariable}  {firstvariable} ");
         Console.WriteLine($"{firstvariable}  {firstvariable} ");
         Console.WriteLine($"{firstvariable}{firstvariable}{firstvariable}{firstvariable} ");
          
}
}
