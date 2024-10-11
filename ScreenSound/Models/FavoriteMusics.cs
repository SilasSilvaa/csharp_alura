using System.Text.Json;

namespace ScreenSound.Models;

internal class FavoriteMusics
{
    public FavoriteMusics(string name) 
    {
        Name = name;
        FavoriteSongList = new List<Music>();   
    }

    public string? Name { get; set; }
    public List<Music> FavoriteSongList { get; set; }
      
    public void AddFavoriteSong(Music music)
    {
       FavoriteSongList.Add(music);
    }

    public void ShowFavoriteSongs()
    {
        FavoriteSongList.ForEach(song => Console.WriteLine($"Artist: {song.Artist} - Music: {song.Song}"));
    }

    public void GenerateJsonFile()
    {
        string json = JsonSerializer.Serialize(new
        {
            name = Name,
            music = FavoriteSongList
        });

        string fileName = $"music-favorites-{Name}.json";
        
        File.WriteAllText(fileName, json );
        Console.WriteLine("json file created successfully");
    }
}
