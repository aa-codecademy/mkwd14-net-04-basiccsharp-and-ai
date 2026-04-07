namespace CinemaExercise
{
    public class Movie
    {
        public string Title { get; private set; }
        public Genre Genre { get; private set; }
        public double Rating { get; private set; }
        public double TicketPrice { get; private set; }
        //public double TicketPrice => 5 * Rating;

        public Movie(string title, Genre genre, double rating)
        {
            if(rating < 1 || rating > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Rating must be between 1 and 10.");
            }

            Title = title;
            Genre = genre;
            Rating = rating;
            TicketPrice = 5 * rating;
        }

        public void UpdateRating(double newRating)
        {
            if (newRating < 1 || newRating > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(newRating), "Rating must be between 1 and 10.");
            }

            Rating = newRating;
            TicketPrice = 5 * newRating;
        }
    }
}
