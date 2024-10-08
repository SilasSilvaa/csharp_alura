using OpenAI_API;
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuRegisterBand : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBand)
    {
        base.Execute(registeredBand);
        ShowTitleOption("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string bandName = Console.ReadLine()!;
         
        Band band = new Band(bandName);
        registeredBand.Add(bandName, band);

        OpenAIAPI client = new OpenAIAPI("API KEY");

        var chat = client.Chat.CreateConversation();

        chat.AppendSystemMessage($"Resuma a banda {bandName} em 1 paragrafo, Adote um estilo informal");

        string response = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        band.Response = response;

        Console.WriteLine($"A banda {bandName} foi registrada com sucesso!");

        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    
    }
}
