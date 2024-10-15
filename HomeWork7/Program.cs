using System;

class Program
{
    static void Main()
    {
        // კვადრატების სხვაობა
        // Console.WriteLine("Enter Radius");
        // var radius = double.Parse(Console.ReadLine());
        //
        // var BigSquare = (radius * 2) * (radius * 2); // დიდი კვადრატის ფართობი S=(2r)^2
        // var SmallSquare = (radius * Math.Sqrt(2)) * (radius * Math.Sqrt(2)); // პატარა კვადრატის ფართობი S=(r*√2)^2
        // var Difference = BigSquare - SmallSquare; // სხვაობა 
        //
        // Console.WriteLine($"Difference is: {areaDifference}");

        // ამოწმებს ჯეკპოტს
        // TODO როგორ გავაკეთო ისე, რომ ნებისმიერად შეყვანილი კომბინაცია წაიკითხოს პროგრამამ 
        // Console.WriteLine("Enter your combination (e.g. a,a,a,a)");
        // var input = Console.ReadLine();
        //
        // if (string.IsNullOrEmpty(input))
        // {
        //     Console.WriteLine("You must enter a combination.");
        //     return;
        // }
        //
        // var firstChar = input[0];
        // bool allSame = true;
        // var characters = input.Replace(" ", "").Split(',');
        //
        // for (int i = 1; i < characters.Length; i++)
        // {
        //     if (input[i] != firstChar)
        //     {
        //         allSame = false;
        //         break;
        //     }
        // }
        //
        // Console.WriteLine(allSame ? "Yes" : "No");

        // ფეხბურთის ქულები
        // Console.WriteLine("Enter winning game number:");
        // var winningGame = int.Parse(Console.ReadLine());
        // Console.WriteLine("Enter losing game number:");
        // var losingGame = int.Parse(Console.ReadLine());
        // Console.WriteLine("Enter tied game number:");
        // var tiedGame = int.Parse(Console.ReadLine());
        //
        // var totalPoints = (winningGame * 3) + (losingGame * 0) + (tiedGame * 1);
        // Console.WriteLine($"Total points: {totalPoints}");

        // სამუშაო საათები
        // Console.Write("How many hours did you work on weekdays (Mon-Fri): ");
        // var weekdaysHours = Convert.ToInt32(Console.ReadLine());
        // Console.Write("How many overtime hours did you work: ");
        // var overtimeHours = Convert.ToInt32(Console.ReadLine());
        // Console.Write("How many hours did you work on weekends (Sat-Sun): ");
        // var weekendHours = Convert.ToInt32(Console.ReadLine());
        //
        // var sallary = (weekdaysHours * 10) + (overtimeHours * 15) + (weekendHours * 20);
        // Console.WriteLine($"Your sallary is: {weekdaysHours}*10 + {overtimeHours}*15 + {weekendHours}*20 = {sallary}");

        // სამუშაო საათები v2
        // Console.WriteLine("Enter the number of hours worked for each day (e.g: 8, 8, 8, 8, 8, 8, 0)");
        // var input = Console.ReadLine();
        // string[] hoursInput = input.Split(',');
        // int[] hours = Array.ConvertAll(hoursInput, int.Parse);
        //
        // var weedaysHours = 10;
        // var OvertimeHours = 15;
        // var WeekEndHours = 20; // or multiplayer 2??
        //
        // var totalsalary = 0;
        //
        // for (int i = 0; i < hours.Length; i++)
        // {
        //     if (i < 5)
        //     {
        //         if (hours[i] > 8)
        //         {
        //             totalsalary += (8 * weedaysHours) + ((hours[i] - 8) * OvertimeHours);
        //         }
        //         else
        //         {
        //             totalsalary += hours[i] * weedaysHours;
        //         }
        //     }
        //     else
        //     {
        //         totalsalary += hours[i] * WeekEndHours;
        //     }
        // }
        //
        // Console.WriteLine($"Your Salary is: {totalsalary}");

        // ვარჯიში
        // Console.WriteLine("Enter your workout results separated (e.g. 5, 8, 8, 9, 10): ");
        // string input = Console.ReadLine();
        //
        // string[] resultsInput = input.Split(',');
        // int[] results = Array.ConvertAll(resultsInput, int.Parse);
        //
        // var progressDays = 0;
        //
        // for (int i = 1; i < results.Length; i++)
        // {
        //     if (results[i] > results[i - 1])
        //     {
        //         progressDays++;
        //     }
        // }
        //
        // Console.WriteLine(progressDays);

        // LINQ
        string[] words = { "Hello", "World", "Programming", "communication" };
        Console.WriteLine("enter number");
        var n = 0;
        
        if (int.TryParse(Console.ReadLine(), out n))
        {
            var matchingWords = words.Where(word => word.Length == n).ToArray();
        
            if (matchingWords.Length > 0)
            {
                Console.WriteLine($"elements with number {n}: {string.Join(", ", matchingWords)}");
            }
            else
            {
                Console.WriteLine("No elements found");
            }
        }
        else
        {
            Console.WriteLine("enter proper number");
        }
    }
}