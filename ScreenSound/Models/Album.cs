using ScreenSound.Interfaces;

namespace ScreenSound.Models;

internal class Album : IEvaluable
{
    private List<Music> musics = new List<Music>();
    private List<Rating> ratings = new List<Rating>();

    public Album(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public int TotalDuration => musics.Sum(m => m.Duration);
    public List<Music> Musics => musics;

    public double Avarage => ratings.Count < 0 ? 0 : ratings.Average(n => n.Value);

    public void AddNote(Rating note)
    {
        ratings.Add(note);
    }

    public void AdicionarMusica(Music music)
    {
        musics.Add(music);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Name}:\n");
        foreach (var musica in musics)
        {
            Console.WriteLine($"Música: {musica.Name}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {TotalDuration}");
    }
}