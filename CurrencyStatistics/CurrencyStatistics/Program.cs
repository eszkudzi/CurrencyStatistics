using System;
using CurrencyStatistics;

Console.WriteLine("Hello to the Currency Statistics console app.");
Console.WriteLine("---------------------------------------");
Console.WriteLine("1 - Add Euro values to the program memory and show statistics\n" + "2 - Add Euro values to the .txt file and show statistics\n" + "X - Close app");
Console.WriteLine("---------------------------------------");
Console.WriteLine("What you want to do? \nPress key 1, 2 or X: ");

var userInput = Console.ReadLine();

switch (userInput)
{
    case "1":
        var currency1 = new CurrencyInMemory("Euro");

        while (true)
        {
            Console.WriteLine("Podaj kolejną ocenę pracownika: ");
            var input = Console.ReadLine();
            if (input == "q")
            {
                break;
            }
            try
            {
                currency1.AddValues(input);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception catch: {e.Message}");
            }

        }

        var stats1 = currency1.GetStatistics();
        Console.WriteLine($"Average: {stats1.Average:N2}");
        Console.WriteLine($"Min: {stats1.Min}");
        Console.WriteLine($"Max: {stats1.Max}");
        break;

    case "2":
        var currency2 = new CurrencyInFile("Euro");
        var stats2 = currency2.GetStatistics();
        Console.WriteLine($"Average: {stats2.Average:N2}");
        Console.WriteLine($"Min: {stats2.Min}");
        Console.WriteLine($"Max: {stats2.Max}");
        break;

    case "X":
    case "x":
        break;
    default:
        Console.WriteLine("Invalid operation.\n");
        break;
        //continue;
}
