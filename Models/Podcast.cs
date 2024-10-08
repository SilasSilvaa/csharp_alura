
public class Podcast
{
    public Podcast(String host, String name)
    {
        Host = host;
        Name = name;
    }

    public String Host { get; }
    public String Name { get; }
    private readonly List<Episode> episodes = new List<Episode>();

    public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
        Console.WriteLine("Episode was add -> " + episode.Name);
    }

    public void ShowPodcast()
    {
        Console.WriteLine($"Host: {Host}");
        Console.WriteLine($"Name: {Name}");
        foreach (Episode episode in episodes)
        {
            Console.WriteLine($"Ep name: {episode.Name}");
        }
        Console.WriteLine($"Total Eps {episodes.Count}");
    }
}