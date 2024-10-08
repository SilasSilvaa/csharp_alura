using ScreenSound.Interfaces;

namespace ScreenSound.Models;

internal class Band : IEvaluable
{
    private List<Album> albums = new List<Album>();
    private List<Rating> ratings = new List<Rating>();

    public Band(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public double Avarage => ratings.Count < 0 ? 0 : ratings.Average(n => n.Value);
    public List<Album> Albums => albums;

    public string? Response { get; set; }
    public void AddToAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AddNote(Rating note)
    {
        ratings.Add(note);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Name}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Name} ({album.TotalDuration})");
        }
    }
}