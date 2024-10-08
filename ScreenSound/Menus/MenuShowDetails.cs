using ScreenSound.Models;

namespace ScreenSound.Menus;
internal class MenuShowDetails : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBand)
    {
        base.Execute(registeredBand);
        ShowTitleOption("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string bandName = Console.ReadLine()!;
        if (registeredBand.ContainsKey(bandName))
        {
            Band band = registeredBand[bandName];
            Console.WriteLine(band.Response);

            Console.WriteLine($"\nA média da banda {bandName} é {band.Avarage}.");
            Console.WriteLine("Discografia: ");
            foreach (Album album in band.Albums)
            {
                Console.WriteLine($"{album.Name} - {album.Avarage}");
            }

        Console.WriteLine("Digite uma tecla para votar ao menu principal");
            Console.ReadKey();
            Console.Clear();

        }
        else
        {
            Console.WriteLine($"\nA banda {bandName} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
