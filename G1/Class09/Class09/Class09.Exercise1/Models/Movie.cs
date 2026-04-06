namespace Class09.Exercise1.Models;

public class Movie
{
    public string Title { get; set; }
    public Genre Genre { get; set; }
    public int Rating { get; set; }
    public int TicketPrice { get; set; }

    public Movie(string title, Genre genre, int rating)
    {
        try
        {
            Title = title;
            Genre = genre;
            if (rating < 1 || rating > 5)
                throw new ArgumentOutOfRangeException("Can't insert value for rating that is not between 1 and 5.");
            Rating = rating;
            TicketPrice = Rating * 5;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
    }
}
