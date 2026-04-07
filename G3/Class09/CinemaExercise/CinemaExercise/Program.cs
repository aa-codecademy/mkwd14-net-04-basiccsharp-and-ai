// See https://aka.ms/new-console-template for more information
using CinemaExercise;

Console.WriteLine("Movie night!");

var cinema = new Cinema();
cinema.Name = "Cineplex";
cinema.NumberOfHalls = 5;

// Create 10 movie objects based on top IMDB movies
var movie1 = new Movie("The Shawshank Redemption", Genre.Drama, 9.3);
var movie2 = new Movie("The Godfather", Genre.Drama, 9.2);
var movie3 = new Movie("The Dark Knight", Genre.Action, 9.0);
var movie4 = new Movie("The Godfather Part II", Genre.Drama, 9.0);
var movie5 = new Movie("12 Angry Men", Genre.Drama, 9.0);
var movie6 = new Movie("Schindler's List", Genre.Drama, 8.9);
var movie7 = new Movie("The Lord of the Rings: The Return of the King", Genre.Action, 8.9);
var movie8 = new Movie("Pulp Fiction", Genre.Drama, 8.8);
var movie9 = new Movie("The Lord of the Rings: The Fellowship of the Ring", Genre.Action, 8.8);
var movie10 = new Movie("Forrest Gump", Genre.Drama, 8.8);

// Assign movies to cinema
cinema.Movies.Add(movie1);
cinema.Movies.Add(movie2);
cinema.Movies.Add(movie3);
cinema.Movies.Add(movie4);
cinema.Movies.Add(movie5);
cinema.Movies.Add(movie6);
cinema.Movies.Add(movie7);
cinema.Movies.Add(movie8);
cinema.Movies.Add(movie9);
cinema.Movies.Add(movie10);

var cinema2 = new Cinema()
{
    Name = "Milenium",
    NumberOfHalls = 2,
};

// Create 10 more movie objects for cinema2 based on next top IMDB movies
var movie11 = new Movie("The Good, the Bad and the Ugly", Genre.Action, 8.8);
var movie12 = new Movie("Fight Club", Genre.Drama, 8.8);
var movie13 = new Movie("The Lord of the Rings: The Two Towers", Genre.Action, 8.7);
var movie14 = new Movie("Inception", Genre.SciFi, 8.7);
var movie15 = new Movie("Star Wars: Episode V - The Empire Strikes Back", Genre.SciFi, 8.7);
var movie16 = new Movie("The Matrix", Genre.SciFi, 8.7);
var movie17 = new Movie("Goodfellas", Genre.Drama, 8.7);
var movie18 = new Movie("One Flew Over the Cuckoo's Nest", Genre.Drama, 8.6);
var movie19 = new Movie("Interstellar", Genre.SciFi, 8.6);
var movie20 = new Movie("Se7en", Genre.Drama, 8.6);

// Assign movies to cinema2
cinema2.Movies.Add(movie11);
cinema2.Movies.Add(movie12);
cinema2.Movies.Add(movie13);
cinema2.Movies.Add(movie14);
cinema2.Movies.Add(movie15);
cinema2.Movies.Add(movie16);
cinema2.Movies.Add(movie17);
cinema2.Movies.Add(movie18);
cinema2.Movies.Add(movie19);
cinema2.Movies.Add(movie20);

List<Cinema> cinemas = new List<Cinema>() { cinema, cinema2 };

try
{
    Console.WriteLine("Choose a cinema:");
    for (int i = 0; i < cinemas.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {cinemas[i].Name}");
    }

    int cinemaChoice;

    while (!int.TryParse(Console.ReadLine(), out cinemaChoice) || cinemaChoice < 1 || cinemaChoice > cinemas.Count)
    {
        Console.WriteLine("Invalid choice. Please enter a valid number corresponding to a cinema.");
    }

    var selectedCinema = cinemas[cinemaChoice - 1];

    Console.WriteLine($"You selected: {selectedCinema.Name}");
    Console.WriteLine("Select how you want to list the movies:");
    Console.WriteLine("1. All movies");
    Console.WriteLine("2. By genre");

    int selectionChoice;
    int genreChoice = 0;

    while (!int.TryParse(Console.ReadLine(), out selectionChoice) || (selectionChoice != 1 && selectionChoice != 2))
    {
        Console.WriteLine("Invalid choice. Please enter 1 or 2.");
    }

    if (selectionChoice == 1)
    {
        for (var i = 0; i < selectedCinema.Movies.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {selectedCinema.Movies[i].Title} ({selectedCinema.Movies[i].Genre}), Rating: {selectedCinema.Movies[i].Rating}, Ticket Price: {selectedCinema.Movies[i].TicketPrice}");
        }
    }
    else if (selectionChoice == 2)
    {
        Console.WriteLine("Select a genre:");
        var genres = Enum.GetValues(typeof(Genre)).Cast<Genre>().ToList();

        foreach (var genre in genres)
        {
            Console.WriteLine($"{(int)genre}. {genre}");
        }

        while (!int.TryParse(Console.ReadLine(), out genreChoice) || !Enum.IsDefined(typeof(Genre), genreChoice)) //(genreChoice < (int)Genre.Comedy || genreChoice > (int)Genre.SciFi)
        {
            Console.WriteLine("Invalid choice. Please enter a valid number corresponding to a genre.");
        }

        var filteredMovies = selectedCinema.Movies.Where(m => (int)m.Genre == genreChoice).ToList();
        for (var i = 0; i < filteredMovies.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {filteredMovies[i].Title} ({filteredMovies[i].Genre}), Rating: {filteredMovies[i].Rating}, Ticket Price: {filteredMovies[i].TicketPrice}");
        }
    }

    while (true)
    {
        Console.WriteLine("Select a movie to see details (enter the number):");
        if (!int.TryParse(Console.ReadLine(), out int selectedMovieChoice))
        {
            Console.WriteLine("Invalid choice. Please enter a valid number corresponding to a movie.");
            continue;
        }

        if (selectionChoice == 1)
        {
            if (selectedMovieChoice < 1 || selectedMovieChoice > selectedCinema.Movies.Count)
            {
                Console.WriteLine("Invalid choice. Please enter a valid number corresponding to a movie.");
                continue;
            }
            else
            {
                var selectedMovie = selectedCinema.Movies[selectedMovieChoice - 1];
                Console.WriteLine(selectedCinema.MoviePlaying(selectedMovie));
                break;
            }
        }
        else if (selectionChoice == 2)
        {
            var filteredMovies = selectedCinema.Movies.Where(m => (int)m.Genre == genreChoice).ToList();

            if (selectedMovieChoice < 1 || selectedMovieChoice > filteredMovies.Count)
            {
                Console.WriteLine("Invalid choice. Please enter a valid number corresponding to a movie.");
                continue;
            }
            else
            {
                var selectedMovie = filteredMovies[selectedMovieChoice - 1];
                Console.WriteLine(selectedCinema.MoviePlaying(selectedMovie));
                break;
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine("We are sorry, but an error occurred while processing your request.");
    // Log the exception details for debugging purposes
}
finally
{
    Console.WriteLine("Thank you for using the cinema application!");
}
