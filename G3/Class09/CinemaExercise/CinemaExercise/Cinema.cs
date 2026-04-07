namespace CinemaExercise
{
    public class Cinema
    {
        public string Name { get; set; }
        public int NumberOfHalls { get; set; }
        public List<Movie> Movies { get; set; } = new List<Movie>();

        //public Cinema()
        //{
        //    Movies = new List<Movie>();
        //}

        public string MoviePlaying(Movie movie)
        {
            if(!Movies.Any(x => string.Equals(x.Title, movie.Title, StringComparison.OrdinalIgnoreCase)))
            {
                throw new Exception($"Movie '{movie.Title}' is not currently playing in the cinema.");
            }
            return $"Now playing: {movie.Title} ({movie.Genre}), Rating: {movie.Rating}, Ticket Price: {movie.TicketPrice}";
        }
    }
}
