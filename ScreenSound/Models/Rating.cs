namespace ScreenSound.Models;

internal class Rating
{
    public Rating(int value)
    {
        Value = value;
    }

    public int Value { get; }

    public static Rating ToRating(string value)
    {
        int rating = int.Parse(value);
        return new Rating(rating);
    }

}
