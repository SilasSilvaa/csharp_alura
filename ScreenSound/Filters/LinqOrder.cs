
using ScreenSound.Models;

namespace ScreenSound.Filters;

internal class LinqOrder
{
    public static void ShowOrderArtist(List<Music> musics)
    {
        var ordainedArtist = musics.OrderBy(m => m.Artist).Select(s => s.Artist).Distinct().ToList();

        ordainedArtist.ForEach(o => Console.WriteLine($"- {o}"));
    }
}
