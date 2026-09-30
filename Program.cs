using MovieBookingSystem.Models;
using MovieBookingSystem.Services;

class Program
{
    static void Main()
    {
        List<Movie> movies = new List<Movie>();

        // Default movies
        movies.Add(
            new Movie(1, "KGF", 200));

        movies.Add(
            new Movie(2, "RRR", 180));

        movies.Add(
            new Movie(3, "Avengers", 250));


        // Start application
        MenuService.MainMenu(movies);
    }
}