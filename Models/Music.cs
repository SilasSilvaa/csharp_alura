
public class Music
{
    public Music(Band band, string name, int duration, bool available, Genre genre)
    {
        Artist = band;
        Name = name;
        Duration = duration;
        Available = available;
        Genre = genre;
    }

    public Band Artist { get; }
    public string Name { get; }
    public int Duration { get; }
    public bool Available { get; }
    public Genre Genre { get; }
    public string Description => $"Music name {Name} is from the band {Artist}";


    public void Show()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Duration: {Duration}");
        Console.WriteLine($"Description: {Description}");

        if (Available)
        {
            Console.WriteLine("Avaliable");
        }
        else
        {
            Console.WriteLine("Not Avaliable");
        }
    }
}