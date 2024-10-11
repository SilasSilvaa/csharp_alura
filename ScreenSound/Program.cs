using System.Text.Json;
using ScreenSound.Filters;
using ScreenSound.Models;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        List<Music> musics = JsonSerializer.Deserialize<List<Music>>(response);
        LinqFilter.FilterByGenre(musics);
        LinqOrder.ShowOrderArtist(musics);
        LinqFilter.FilterArtistByMusicalGenre(musics, "hip hop");
        LinqFilter.FilterMusicByArtist(musics, "Eminem");
        LinqFilter.FilterMusicByTonality(musics, "C#");
        FavoriteMusics favoriteMusics = new FavoriteMusics("User");

        favoriteMusics.AddFavoriteSong(musics[50]);
        favoriteMusics.AddFavoriteSong(musics[5]);
        favoriteMusics.AddFavoriteSong(musics[70]);
        favoriteMusics.AddFavoriteSong(musics[140]);

        favoriteMusics.ShowFavoriteSongs();
        favoriteMusics.GenerateJsonFile();



    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

}