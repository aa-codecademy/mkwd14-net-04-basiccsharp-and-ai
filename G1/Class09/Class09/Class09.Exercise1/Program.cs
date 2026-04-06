using Class09.Exercise1.Models;


#region Test data
// Cineplexx
var cineplexxMovies = new List<Movie>
{
    new Movie("Titanic", Genre.Drama, 9),
    new Movie("The Shawshank Redemption", Genre.Drama, 5),
    new Movie("The Godfather", Genre.Drama, 5),
    new Movie("The Dark Knight", Genre.Action, 5),
    new Movie("Inception", Genre.SciFi, 5),
    new Movie("Toy Story", Genre.Comedy, 4),
    new Movie("Get Out", Genre.Horror, 4),
    new Movie("Alien", Genre.SciFi, 4),
    new Movie("Raiders of the Lost Ark", Genre.Action, 4),
    new Movie("La La Land", Genre.Drama, 4)
};

// Milenium
var mileniumMovies = new List<Movie>
{
    new Movie("Avengers: Endgame", Genre.Action, 5),
    new Movie("Interstellar", Genre.SciFi, 5),
    new Movie("The Conjuring", Genre.Horror, 4),
    new Movie("Parasite", Genre.Drama, 5),
    new Movie("The Hangover", Genre.Comedy, 4),
    new Movie("Mad Max: Fury Road", Genre.Action, 5),
    new Movie("Pulp Fiction", Genre.Drama, 5),
    new Movie("A Quiet Place", Genre.Horror, 4),
    new Movie("Back to the Future", Genre.SciFi, 5),
    new Movie("Joker", Genre.Drama, 4)
};

var cinemas = new List<Cinema>
{
    new Cinema { Name = "Cineplexx", Halls = 7, Movies = cineplexxMovies },
    new Cinema { Name = "Milenium", Halls = 6, Movies = mileniumMovies },
};


#endregion

while (true)
{
    try
    {
        Console.WriteLine("Choose a cinema:");
        Console.WriteLine("1)" + cinemas[0].Name);
        Console.WriteLine("2)" + cinemas[1].Name);
        int cinemaInput = Int32.Parse(Console.ReadLine());
        Cinema currentCinema = new Cinema();
        if (cinemaInput == 1)
        {
            currentCinema = cinemas[0];
        }
        else if (cinemaInput == 2)
        {
            currentCinema = cinemas[1];
        }
        else
        {
            throw new Exception("You have to enter 1 or 2! Sorry! You broke it!");
        }
        Console.WriteLine("Movies in this cinema:");
        Console.WriteLine("1) Show all movies");
        Console.WriteLine("2) Show by genre");
        int moviesInput = Int32.Parse(Console.ReadLine());
        if (moviesInput == 1)
        {
            Console.WriteLine("Choose a movie to watch: ( Write the name )");
            var i = 1;

            foreach (var movie in currentCinema.Movies)
            {
                Console.WriteLine($"{i++} {movie.Title}");
            }
            bool inputMovie = int.TryParse(Console.ReadLine(), out int movieSelection);
            if (inputMovie)
                currentCinema.MoviePlaying(currentCinema.Movies.ElementAt(movieSelection - 1));
        }
        else if (moviesInput == 2)
        {
            Console.WriteLine("Enter genre:");
            Console.WriteLine("1) Comedy");
            Console.WriteLine("2) Horror");
            Console.WriteLine("3) Action");
            Console.WriteLine("4) Drama");
            Console.WriteLine("5) SciFi");
            int inputGenre = Int32.Parse(Console.ReadLine());
            Genre currentGenre = new Genre();
            switch (inputGenre)
            {
                case 1:
                    currentGenre = Genre.Comedy;
                    break;
                case 2:
                    currentGenre = Genre.Horror;
                    break;
                case 3:
                    currentGenre = Genre.Action;
                    break;
                case 4:
                    currentGenre = Genre.Drama;
                    break;
                case 5:
                    currentGenre = Genre.SciFi;
                    break;
                default:
                    throw new Exception("The genre input was not correct! Sorry, you broke it!");
            }

            Console.WriteLine("Choose a movie to watch:");
            List<Movie> personMovies = new List<Movie>();
            var i = 1;
            foreach (var movie in currentCinema.Movies.Where(movie => movie.Genre == currentGenre).ToList())
            {
                personMovies.Add(movie);
                Console.WriteLine($"{i++} {movie.Title}");
            }
            bool inputMovie = int.TryParse(Console.ReadLine(), out int movieSelection);
            if (inputMovie)
                currentCinema.MoviePlaying(personMovies.ElementAt(movieSelection - 1));
        }
        else
        {
            throw new Exception("You have entered a wrong input!");
        }

        Console.WriteLine("Do you want to watch another movie? y/n");
        string userInput = Console.ReadLine();
        if (userInput.ToLower() == "n")
            break;
        Console.Clear();
    }
    catch (FormatException)
    {
        Console.WriteLine("You did not enter a correct format and you broke it!");
    }
    catch (NullReferenceException)
    {
        Console.WriteLine("There is no movie like that!");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

