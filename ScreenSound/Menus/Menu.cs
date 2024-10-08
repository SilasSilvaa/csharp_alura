
using ScreenSound.Models;

namespace ScreenSound.Menus;
internal class Menu
{
    public void ShowTitleOption(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asterisks = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asterisks);
        Console.WriteLine(titulo);
        Console.WriteLine(asterisks + "\n");
    }


    public virtual void Execute(Dictionary<string, Band> registeredBand)
    {
        Console.Clear();
    }
}
