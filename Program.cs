//Screen Sound
string welcomeMessage = "Welcome to Screen Sound";

Dictionary<string, List<int>> bandList = new Dictionary<string, List<int>>()
{
    {"Band1", [10, 10, 9]},
    {"Band2", [7, 8, 9]},
    {"Band3", [10, 10, 6]},
};


void ShowMessage()
{
    Console.WriteLine("------------------------");
    Console.WriteLine(welcomeMessage);
    Console.WriteLine("------------------------");
}

void RegisterBand()
{
    Console.Clear();

    Console.Write("Tyep band name: ");
    string bandName = Console.ReadLine()!;

    Console.WriteLine($"Band {bandName} successfully registered");

    bandList.Add(bandName, new List<int>());

    Thread.Sleep(2000);

    Console.Clear();
    OptionsMenu();
}

void showAllBands()
{
    Console.WriteLine("All bands\n");

    foreach (string bandName in bandList.Keys)
    {
        Console.WriteLine(bandName);
    }

    Console.WriteLine("\nType any key for exit");
    Console.ReadKey();
    Console.Clear();
    OptionsMenu();
}

void RatingBand()
{
    Console.Clear();
    Console.WriteLine("Rating band...");
    Console.WriteLine("Type band for rating");
    string name = Console.ReadLine()!;

    if (bandList.ContainsKey(name))
    {
        Console.WriteLine("Your Rating");
        int rating = int.Parse(Console.ReadLine()!);
        bandList[name].Add(rating);

        Thread.Sleep(2000);
        Console.WriteLine("Rated band");
        Console.Clear();
        OptionsMenu();
    }
    else
    {
        Console.WriteLine("Band not found");
        Console.WriteLine("\nType any key for exit");
        Console.ReadKey();
        Console.Clear();
        OptionsMenu();
    }

}

void GetAverage()
{
    Console.Clear();
    Console.WriteLine("Get average band...");
    Console.WriteLine("Type band");
    string name = Console.ReadLine()!;

    if (bandList.ContainsKey(name))
    {
        Console.WriteLine("Avarage");
        Console.WriteLine(bandList[name].Average());

        Thread.Sleep(2000);
        Console.Clear();
        OptionsMenu();
    }
    else
    {
        Console.WriteLine("Band not found");
        Console.WriteLine("\nType any key for exit");
        Console.ReadKey();
        Console.Clear();
        OptionsMenu();

    }
}

void OptionsMenu()
{
    ShowMessage();
    Console.WriteLine("\nType 1 for register a one band");
    Console.WriteLine("Type 2 for show all bands");
    Console.WriteLine("Type 3 for rating a one band");
    Console.WriteLine("Type 4 for show avarage");
    Console.WriteLine("Type -1 for exit");

    Console.Write("\n Type your option: ");
    int option = int.Parse(Console.ReadLine()!);

    switch (option)
    {
        case 1:
            RegisterBand();
            break;
        case 2:
            showAllBands();
            break;
        case 3:
            RatingBand();
            break;
        case 4:
            GetAverage();
            break;
        case -1:
            Console.WriteLine("Bye Bye :)");
            break;

        default:
            Console.WriteLine("Invalid option: " + option);
            break;

    }
}

OptionsMenu();