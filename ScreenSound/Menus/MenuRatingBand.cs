using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuRatingBand : Menu
{

    public override void Execute(Dictionary<string, Band> registeredBand)
    {
        base.Execute(registeredBand);
        ShowTitleOption("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string bandName = Console.ReadLine()!;
        if (registeredBand.ContainsKey(bandName))
        {
            Band band = registeredBand[bandName];
            Console.Write($"Qual a nota que a banda {bandName} merece: ");
            Rating value = Rating.ToRating(Console.ReadLine()!);
            band.AddNote(value);
            Console.WriteLine($"\nA nota {value.Value} foi registrada com sucesso para a banda {bandName}");
            Thread.Sleep(2000);
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
