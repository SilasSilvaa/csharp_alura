using ScreenSound.Models;
using System.Collections.Generic;

namespace ScreenSound.Filters;

public class LinqFilter
{
    public static void FilterByGenre(List<Music> musics)
    {
        List<string?> allGenres = musics.Select(g => g.Genre).Distinct().ToList();
    
        allGenres.ForEach(a => Console.WriteLine($"- {a}"));
    }

    public static void FilterArtistByMusicalGenre(List<Music> musics, string genre)
    {
        List<string?> artistByGenre = musics.Where(m => m.Genre.Contains(genre)).Select(s => s.Artist).Distinct().ToList();

        artistByGenre.ForEach(a => Console.WriteLine($"- {a}"));
    }

    public static void FilterMusicByArtist(List<Music> musics, string artist)
    {
        List<string?> artistMusic = musics.Where(m => m.Artist!.Equals(artist)).Select(s => s.Song).ToList();

        artistMusic.ForEach(a => Console.WriteLine($"- {a}"));
    }

    public static void FilterMusicByTonality(List<Music> musics, string tonality)
    {
        List<string?> tonalityMusics = musics
            .Where(m => m.Tonality.Equals(tonality)).Select(s => s.Song).ToList();

        tonalityMusics.ForEach(t => Console.WriteLine($"- {t}"));
    }
}
