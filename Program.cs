namespace learningcsharp2;
class Program //Write a C# program  that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit
{
    static void Main(string[] args)
    {
        double firstvariable = 5;

        Console.Write("Enter the first number: ");
        firstvariable = Convert.ToDouble( Console.ReadLine() );


        Console.WriteLine($"{firstvariable}*0 = {(firstvariable)*0}");
        Console.WriteLine($"{firstvariable}*1 = {(firstvariable)*1}");
        Console.WriteLine($"{firstvariable}*2 = {(firstvariable)*2}");
        Console.WriteLine($"{firstvariable}*3 = {(firstvariable)*3}");
        Console.WriteLine($"{firstvariable}*4 = {(firstvariable)*4}");
        Console.WriteLine($"{firstvariable}*5 = {(firstvariable)*5}");
        Console.WriteLine($"{firstvariable}*6 = {(firstvariable)*6}");
        Console.WriteLine($"{firstvariable}*7 = {(firstvariable)*7}");
        Console.WriteLine($"{firstvariable}*8 = {(firstvariable)*8}");
        Console.WriteLine($"{firstvariable}*9 = {(firstvariable)*9}");
        Console.WriteLine($"{firstvariable}*10 = {(firstvariable)*10}");
        Console.WriteLine($"{firstvariable}*11 = {(firstvariable)*11}");
        Console.WriteLine($"{firstvariable}*12 = {(firstvariable)*12}");
       

        Console.ReadKey(true);
    }
}
