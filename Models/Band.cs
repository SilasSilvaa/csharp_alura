
public class Band
{
    public Band(string name)
    {
        Name = name;
    }
    private List<Album> albums = new List<Album>();
    public string Name { get; set; }

    public void AddtoAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ShowAlbuns()
    {
        foreach (var album in albums)
        {
            Console.WriteLine($"Album name: {album.Name} ({album.Duration})");
        }
    }
}