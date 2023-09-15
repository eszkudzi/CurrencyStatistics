using CurrencyStatistics;

Console.WriteLine("Hello to the Currency Statistics console app.");
Console.WriteLine("---------------------------------------");
Console.WriteLine("1 - Add currency values to the program memory and show statistics\n" + "2 - Add currency values to the .txt file and show statistics\n" + "X - Close app");
Console.WriteLine("---------------------------------------");
Console.WriteLine("If you select an illegal value in the menu, the application will also be closed.");
Console.WriteLine("---------------------------------------");
Console.WriteLine("What you want to do? \nPress key 1, 2 or X: ");

var userSelectionOfOptions = Console.ReadLine();
bool close = false;

while (!close)
{
    switch (userSelectionOfOptions)
    {
        case "1":
            AddCurrencyValuesToMemory();
            break;
        case "2":
            AddCurrencyValuesToTxtFile();
            break;
        case "X":
        case "x":
            close = true;
            break;
        default:
            Console.WriteLine("Invalid operation.");
            close = true;
            break;
    }
}

static void AddCurrencyValuesToMemory()
{
    Console.WriteLine("Enter the name of the currency: ");
    var currencyName = Console.ReadLine();
    var currencyInMemory = new CurrencyInMemory(currencyName);
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("Enter all values to calculate statistics.\n" + "To finish entering data, select the letter \"Q\".");
    Console.WriteLine("---------------------------------------");

    while (true)
    {
        Console.WriteLine("Enter a value: ");
        var input = Console.ReadLine();
        if (input == "q" | input == "Q")
        {
            break;
        }
        try
        {
            currencyInMemory.AddValues(input);

        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catch: {e.Message}");
        }
    }

    var statsInMemory = currencyInMemory.GetStatistics();

    Console.WriteLine($"Statistics have been calculated for currency {currencyName}:");
    Console.WriteLine($"Average: {statsInMemory.Average:N2}");
    Console.WriteLine($"Min: {statsInMemory.Min}");
    Console.WriteLine($"Max: {statsInMemory.Max}");
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("Below you can enter new data to calculate new statistics. The previous data will be deleted from memory.");
}

static void AddCurrencyValuesToTxtFile()
{
    Console.WriteLine("Enter the name of the currency: ");
    var currencyName = Console.ReadLine();
    var currencyInFile = new CurrencyInFile(currencyName);
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("Enter all values to calculate statistics.\n" + "To finish entering data, select the letter \"Q\".");
    Console.WriteLine("---------------------------------------");

    while (true)
    {
        Console.WriteLine("Enter a value: ");
        var input = Console.ReadLine();
        if (input == "q" | input == "Q")
        {
            break;
        }
        try
        {
            currencyInFile.AddValues(input);

        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catch: {e.Message}");
        }
    }

    var statsInFile = currencyInFile.GetStatistics();

    Console.WriteLine($"Statistics have been calculated for currency {currencyName}:");
    Console.WriteLine($"Average: {statsInFile.Average:N2}");
    Console.WriteLine($"Min: {statsInFile.Min}");
    Console.WriteLine($"Max: {statsInFile.Max}");
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("Below you can enter new data to calculate new statistics.");
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("If you do not delete the data from the file, statistics will be calculated for all entered values.");
    Console.WriteLine("Select \"Y\" to remove the data from the file.\n" + "If the data is to remain in the file, select any key.");

    var removalDecision = Console.ReadLine();
    if (removalDecision == "y" | removalDecision == "Y")
    {
        currencyInFile.RemoveDataFromFile();
        Console.WriteLine("The file has been cleared.");
    }
}


