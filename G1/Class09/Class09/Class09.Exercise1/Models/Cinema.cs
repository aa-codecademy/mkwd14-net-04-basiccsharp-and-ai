namespace Class09.Exercise1.Models;

public class Cinema
{
    public string Name { get; set; }
    public int Halls { get; set; }
    public List<Movie> Movies { get; set; }

    public void MoviePlaying(Movie movie)
    {
        Console.WriteLine($"Watching {movie.Title}");
    }
}
