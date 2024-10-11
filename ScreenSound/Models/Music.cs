using System.Text.Json.Serialization;

namespace ScreenSound.Models;

public class Music
{
    public Music(string artist, string song, int duration, string genre, int key)
    {
        Artist = artist;
        Song = song;
        Duration = duration;
        Genre = genre;
        Key = key;
    }

    private string[] Tonalities = new string[] { "C", "C#", "D", "Eb", "E", "F",
        "F#", "G", "Ab", "A", "Bb", "b" };

    [JsonPropertyName("artist")]
    public string? Artist { get; }

    [JsonPropertyName("song")]
    public string? Song { get; }

    [JsonPropertyName("duration_ms")]
    public int Duration { get; }

    [JsonPropertyName("genre")]
    public string? Genre { get; }

    [JsonPropertyName("key")]
    public int Key { get; }

    public string Tonality => Tonalities[Key];

    public void ShowDetailMusic()
    {
        Console.WriteLine($"{Artist}");
        Console.WriteLine($"{Song}");
        Console.WriteLine($"{Duration}ms");
        Console.WriteLine($"{Genre}");
        Console.WriteLine($"{Tonality}");
    }

}
