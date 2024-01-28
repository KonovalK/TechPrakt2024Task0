
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello!");
        myFunc();
    }
    internal static void myFunc() 
    {
        Console.WriteLine($"Input a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine($"Input b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine($"{a} + {b} = {a+b}");
    }
}