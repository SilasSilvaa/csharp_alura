

using ScreenSound.Models;

namespace ScreenSound.Menus;
internal class MenuShowBandRegistered : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBand)
    {
        base.Execute(registeredBand);
        ShowTitleOption("Exibindo todas as bandas registradas na nossa aplicação");

        foreach (string banda in registeredBand.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();

    }
}
