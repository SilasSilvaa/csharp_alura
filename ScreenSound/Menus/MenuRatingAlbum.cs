
using ScreenSound.Models;
using System.Linq;

namespace ScreenSound.Menus;

internal class MenuRatingAlbum : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBand)
    {
        base.Execute(registeredBand);

        ShowTitleOption("Avaliar album");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string bandName = Console.ReadLine()!;

        if (registeredBand.ContainsKey(bandName))
        {
            Band band = registeredBand[bandName];
            Console.Write("Agora digite o título do álbum: ");
            string albumTitle = Console.ReadLine()!;


            if (band.Albums.Any(a => a.Name == albumTitle))   
            {
                Album album = band.Albums.First(a => a.Name == albumTitle);

                Console.Write($"Qual a nota que a banda {albumTitle} merece: ");
                Rating value = Rating.ToRating(Console.ReadLine()!);

                album.AddNote(value);
                Console.WriteLine($"\nA nota {value.Value} foi registrada com sucesso para a banda {album.Name}");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nO titulo do album {albumTitle} não foi encontrado!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }

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
