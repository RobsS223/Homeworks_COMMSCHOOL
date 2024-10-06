namespace HomeWork4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        var name = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"Hello {name}!");
        Console.ResetColor();
    }
}