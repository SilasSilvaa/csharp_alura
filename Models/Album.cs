
public class Album
{
    public Album(string name)
    {
        Name = name;
    }
    public List<Music> musics { get; set; } = new List<Music>();
    public string Name { get; set; }
    public int Duration => musics.Sum(m => m.Duration);
    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void ShowAllMusics()
    {
        musics.ForEach(music => Console.WriteLine($"Music name: {music.Name}"));
        Console.WriteLine($"\nAlbum time {Duration}");
    }
}