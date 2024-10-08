
public class Episode
{
    private List<string> Guests = new List<string>();
    public Episode(string name, int order, int duration)
    {
        Name = name;
        Order = order;
        Duration = duration;
    }
    public string Name { get; }
    public string Summary => $"{Order} - {Duration} - {Name}";
    public int Order { get; }
    public int Duration { get; }

    public void AddGuests(string guest)
    {
        Guests.Add(guest);
        Console.WriteLine($"Guest was add {guest}");
    }

    public void SummaryEpisodes()
    {
        Console.WriteLine(Summary);

        foreach (var guests in Guests)
        {
            Console.WriteLine("guest: " + guests);
        }
    }
}
