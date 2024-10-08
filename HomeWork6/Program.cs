using System.ComponentModel.Design;
using System.Globalization;
using System.Security.Cryptography;

namespace IT6;

class Program
{
    static void Main(string[] args)
    {
        // დაწერეთ პროგრამა, რომელიც გამოთვლის სიტყვაში ასოების რაოდენობას

        // Console.Write("Enter the word to count the letters: ");
        // var word = Console.ReadLine();
        //
        // var count = from letter in word
        //     group letter by letter // დავაჯგუფეთ სიმბოლოების მიხედვით
        //     into groupedLetters // ობიექტი, სადაც თავსდებიან სიმბოლოები
        //     select groupedLetters; // ვირჩევთ into-დან ერთნაირ ტიპებს
        //
        // foreach (var groupedLetters in count)
        // {
        //     Console.WriteLine(groupedLetters.Key + ": " + groupedLetters.Count());
        // }


        /* შექმენით ქალაქების მასივი.
         * დაწერეთ პროგრამა, რომელიც პარამეტრად მიიღებს 2 სტრინგს. თავსართი და ბოლოსართი.
         * პროგრამამ უნდა იპოვოს ყველა შესაძლო მნიშვნელობა, რომელიც გადაცემული იქნება თავსართით
         * და დამთავრდება გადაცემული ბოლოსართით
         * List: Rome, London, Nairobi, California, Zurich, New Delhi, Amsterdam, Abu Dhabi, Paris
         * Input Ln = Output London
         */

        // List<string> cities = new List<string>()
        // {
        //     "Rome",
        //     "London",
        //     "Nairobi",
        //     "California",
        //     "Zurich",
        //     "New Delhi",
        //     "Amsterdam",
        //     "Abu Dhabi",
        //     "Paris"
        // };
        // Console.Write("Enter the first letter: ");
        // var firstLetter = Console.ReadLine()[0];
        // Console.Write("Enter the last letter: ");
        // var lastLetter = Console.ReadLine()[0];
        //
        // var matchingCities = cities.Where(city => city[0] == firstLetter && city[city.Length - 1] == lastLetter); 
        //
        // foreach (var city in matchingCities)
        // {
        //     Console.WriteLine($"Matching cities: {city}");
        // }


        /* დაწერეთ პროგრამა, რომელიც კონსოლიდან მიიღებს მასივის ზომას, n რაოდენობის ელემენტებს
         * შეინახავს მასივში, შემდეგ ამ მასივიდან გაფილტრავს ლუწ რიცხვებს. ერთ მასივში უნდა შეინახოს კენტები
         * ხოლო მეორეში ლუწები
         * */

        // Console.Write("Enter array size: ");
        // var size = int.Parse(Console.ReadLine()); // ვიგებთ მასივის ზომას
        //
        // int[] numbers = new int[size]; // ვქმნით მასვივს
        //
        // for (int i = 0; i < size; i++)
        // {
        //     Console.WriteLine($"Enter number: {i + 1}");
        //     numbers[i] = int.Parse(Console.ReadLine()); // შეგვყავს რიცხვები მასივში
        // }
        //
        // var evenNumbers = numbers.Where(x => x % 2 == 0).ToList(); // ვიგებთ ლუწ რიცხვებს
        // var oddNumbers = numbers.Where(x => x % 2 != 0).ToList(); // ვიგებთ კენტ რიცხვებს
        //
        // Console.WriteLine("Even numbers:)");
        // foreach (var even in evenNumbers)
        // {
        //     Console.WriteLine(even);
        // }
        //
        // Console.WriteLine("Odd numbers:");
        // foreach (var odd in oddNumbers)
        // {
        //     Console.WriteLine(odd);
        // }

        /* დაწერეთ კონტაქტების აპლიკაცია, რომელსაც ექნება დამატების, წაშლის და განახლების ფუნქციონალი
         */
        // Dictionary<string, string> numbersDictionary = new Dictionary<string, string>();
        // var command = "";
        //
        // while (command != "5")
        // {
        //     Console.WriteLine("Choose an option:");
        //     Console.WriteLine("1. Add");
        //     Console.WriteLine("2. Remove");
        //     Console.WriteLine("3. Update");
        //     Console.WriteLine("4. List");
        //     Console.WriteLine("5. Exit");
        //     Console.Write("Option: ");
        //     command = Console.ReadLine();
        //
        //     switch (command)
        //     {
        //         case "1":
        //             Console.WriteLine("Enter contact name: ");
        //             var name = Console.ReadLine();
        //             Console.WriteLine("Enter contact number: ");
        //             var number = Console.ReadLine();
        //
        //             if (!numbersDictionary.ContainsKey(name))
        //             {
        //                 numbersDictionary[name] = number;
        //                 Console.ForegroundColor = ConsoleColor.Green;
        //                 Console.WriteLine($"Contact {name} added");
        //                 Console.ResetColor();
        //             }
        //             else
        //             {
        //                 Console.WriteLine($"Contact {name} already exist");
        //             }
        //
        //             break;
        //         case "2":
        //             Console.WriteLine("Enter the name of contact to remove");
        //             name = Console.ReadLine();
        //
        //             if (numbersDictionary.Remove(name))
        //             {
        //                 Console.ForegroundColor = ConsoleColor.Red;
        //                 Console.WriteLine($"Contact removed - {name}");
        //                 Console.ResetColor();
        //             }
        //             else
        //             {
        //                 Console.WriteLine($"Contact {name} not found");
        //             }
        //
        //             break;
        //         case "3":
        //             Console.WriteLine("Enter the name of contact to update");
        //             name = Console.ReadLine();
        //             if (numbersDictionary.ContainsKey(name))
        //             {
        //                 Console.WriteLine("Enter new contact number: ");
        //                 var newNumber = Console.ReadLine();
        //                 numbersDictionary[name] = newNumber;
        //                 Console.WriteLine($"Contact {name} updated");
        //             }
        //             else
        //             {
        //                 Console.WriteLine($"Contact {name} not found");
        //             }
        //
        //             break;
        //         case "4":
        //             if (numbersDictionary.Count == 0)
        //             {
        //                 Console.WriteLine("Contact list is empty");
        //             }
        //             else
        //             {
        //                 Console.WriteLine("Contacts:");
        //                 foreach (var contacts in numbersDictionary)
        //                 {
        //                     Console.WriteLine($"{contacts.Key} : {contacts.Value}");
        //                 }
        //             }
        //
        //             break;
        //         case "5":
        //             Console.WriteLine("Exiting application...");
        //             break;
        //
        //         default:
        //             Console.WriteLine("Unknown Command, Please enter proper number.");
        //             break;
        //     }
        // }

        // პროგრამა, რომელიც მასივიდან იღებს რიცხვებს და აჩვენებს მათ ჯამს
        // Console.Write("Enter Massive Size: ");
        // int[] numbers = new int[Convert.ToInt32(Console.ReadLine())];
        //
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     Console.WriteLine($"Enter Number {i + 1}: ");
        //     numbers[i] = (int.Parse(Console.ReadLine()));
        // }
        //
        // var freQ = from i in numbers
        //     group i by i into g
        //         select g;
        // foreach (var item in freQ)
        // {
        //     Console.WriteLine($"{item.Key} appears {item.Count()} times, sum {item.Key * item.Count()}");
        // }

        // დაწერეთ პროგრამა რომელიც გვიჩვენებს ტოპ მონაწილის შედეგს
        // int[] scores = { 5, 6, 7, 3, 4, 6, 9, 8, 10, 8, 1 };
        // Console.Write("Enter the number of top students to display: ");
        // int topCount = int.Parse(Console.ReadLine());
        // var topScores = scores.Distinct().OrderByDescending(score => score).Take(topCount);
        // Console.WriteLine($"Top {topCount} scores:");
        // Console.WriteLine($"Scores: {string.Join(", ", topScores)}");
    }
}