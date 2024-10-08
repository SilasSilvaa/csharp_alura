using ScreenSound.Menus;
using ScreenSound.Models;
using OpenAI_API;


MenuOptions menuOptions = new MenuOptions();

Dictionary<int, Menu> options = new();
options.Add(1, new MenuRegisterBand());
options.Add(2, new MenuRegisterAlbum());
options.Add(3, new MenuShowBandRegistered());
options.Add(4, new MenuRatingBand());
options.Add(5, new MenuShowDetails());
options.Add(6, new MenuRatingAlbum());
options.Add(-1, new MenuExit());


Band band = new Band("Linkin Park");
band.AddNote(new Rating(10));
band.AddNote(new Rating(6));
band.AddNote(new Rating(9));

Band band2 = new Band("The Beatles");
band2.AddNote(new Rating(10));
band2.AddNote(new Rating(7));
band2.AddNote(new Rating(8));

Dictionary<string, Band> registeredBand = new()
{
    { band.Name, band },
    { band2.Name, band2 }
};

void ShowMenuOptions()
{
    menuOptions.ShowMenuOptions();

    Console.Write("\nDigite a sua opção: ");
    int option = int.Parse(Console.ReadLine()!);

    if (options.ContainsKey(option))
    {
        Menu menu = options[option];
        menu.Execute(registeredBand);

        if (option > 0) ShowMenuOptions();

    }
    else
    {
        Console.WriteLine("Opção inválida");
    }

}

ShowMenuOptions();


