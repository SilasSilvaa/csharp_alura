

using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuRegisterAlbum : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBand)
    {
        base.Execute(registeredBand);
        ShowTitleOption("Registro de álbuns");
        Console.Write("Digite a banda cujo álbum deseja registrar: ");
        string bandName = Console.ReadLine()!;


        if (registeredBand.ContainsKey(bandName))
        {
            Console.Write("Agora digite o título do álbum: ");
            string albumTitle = Console.ReadLine()!;

            Band band = registeredBand[bandName];

            band.AddToAlbum(new Album(albumTitle));

            Console.WriteLine($"O álbum {albumTitle} de {bandName} foi registrado com sucesso!");
            Thread.Sleep(4000);
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
