using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuExit : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBand)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}