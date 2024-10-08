namespace IT5;

class Program
{
    static void Main(string[] args)
    {
        // შეამოწმეთ, იყოფა თუ არა რიცხვი 5ზე უნაშთოდ.
        // Console.Write("Enter your number: ");
        // var yourNumber = int.Parse(Console.ReadLine());
        //
        // if (yourNumber % 5 == 0)
        // {
        //     Console.WriteLine("Your number is a multiple of 5.");
        // }
        // else
        // {
        //     Console.WriteLine("Your number is NOT multiple of 5.");
        // }


        // კალკულატორი
        // while (true)
        // {
        //     Console.Write("Enter first number: ");
        //     var firstNumber = double.Parse(Console.ReadLine());
        //     Console.Write("Enter second number: ");
        //     var secondNumber = double.Parse(Console.ReadLine());
        //     Console.WriteLine("Choose an option: |+| |-| |*| |/|");
        //     var operations = Console.ReadLine();
        //
        //     switch (operations)
        //     {
        //         case "+":
        //             Console.WriteLine($"Result is: {firstNumber + secondNumber}");
        //             break;
        //         case "-":
        //             Console.WriteLine($"Result is: {firstNumber - secondNumber}");
        //             break;
        //         case "*":
        //             Console.WriteLine($"Result is: {firstNumber * secondNumber}");
        //             break;
        //         case "/":
        //             if (secondNumber == 0)
        //                 Console.WriteLine("Not allowed to divide by 0");
        //             else
        //                 Console.WriteLine($"Result is: {firstNumber / secondNumber}");
        //             break;
        //         default:
        //             continue;
        //     }
        //
        //     Console.WriteLine("Do you want to continue? (y/n)");
        //     string response = Console.ReadLine().ToLower();
        //     if (response != "y")
        //     {
        //         break;
        //     }
        // }


        // გაუცვალეთ მნიშვნელები ორ ცვლადს შორის
        // Console.WriteLine("Enter x number: ");
        // int x = int.Parse(Console.ReadLine());
        // Console.WriteLine("Enter y number: ");
        // int y = int.Parse(Console.ReadLine());
        //
        // Console.WriteLine($"Before change x = {x}, y = {y}");
        // int z = 0;
        // z = x + y;
        // y = z - y;
        // x = z - x;
        // Console.WriteLine($"After change x = {x}, y = {y}");


        // პროგრამა, რომელიც კონსოლიდან იღრებს რიცხვს და ქმნის გამრავლების ტაბულას
        // Console.Write("Enter the number to multiply: ");
        // var number = Convert.ToInt32(Console.ReadLine());
        //
        // for (int i = 0; i <= 10; i++)
        // {
        //     int result = number * i;
        //     Console.WriteLine($"{number} * {i} = {result}");
        // }
        

        // პროგრამა, რომელიც კონსოლიდან იღებს რიცხვს, პოულობს ყველა ლუწს და ბეჭდავს კვადრატებს
        // Console.Write("Enter number: ");
        // var number = Convert.ToInt32(Console.ReadLine());
        //
        // for (var i = 1; i <= number; i++)
        // {
        //     int multiply = i * i;
        //     
        //     if (i % 2 == 0)
        //         Console.WriteLine($"{i} * {i} = {multiply}");
        // }
    }
}