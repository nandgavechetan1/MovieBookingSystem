using MovieBookingSystem.Models;

namespace MovieBookingSystem.Services;

class MovieService
{
    // View all movies
    public static void ViewMovies(List<Movie> movies)
    {
        Console.WriteLine("\n========== MOVIES ==========");

        foreach (Movie movie in movies)
        {
            Console.WriteLine(
                "ID: " + movie.Id +
                " | Name: " + movie.Name +
                " | Price: " + movie.Price);
        }

        Console.WriteLine("============================");
    }


    // Add a new movie
    public static void AddMovie(List<Movie> movies)
    {
        int id;

        while (true)
        {
            bool isExist = false;

            Console.Write("Enter Movie ID: ");

            if (int.TryParse(Console.ReadLine(), out id) && id > 0)
            {
                foreach (Movie movie in movies)
                {
                    if (movie.Id == id)
                    {
                        isExist = true;
                        Console.WriteLine("Movie ID already exists!");
                        break;
                    }
                }

                if (!isExist)
                {
                    break;
                }

                continue;
            }

            Console.WriteLine(
                "Invalid ID! Movie ID must contain only numbers.");
        }


        Console.Write("Enter Movie Name: ");
        string name = Console.ReadLine();


        int price;

        while (true)
        {
            Console.Write("Enter Price: ");

            if (int.TryParse(Console.ReadLine(), out price) &&
                price >= 0)
            {
                break;
            }

            Console.WriteLine(
                "Invalid Price! Price must contain only numbers.");
        }


        Movie newMovie = new Movie(id, name, price);

        movies.Add(newMovie);

        Console.WriteLine("Movie Added Successfully");
    }


    // Delete movie
    public static void DeleteMovie(List<Movie> movies)
    {
        int id;

        while (true)
        {
            Console.Write("Enter Movie ID: ");

            if (int.TryParse(Console.ReadLine(), out id) &&
                id > 0)
            {
                break;
            }

            Console.WriteLine("Invalid ID");
        }


        for (int i = 0; i < movies.Count; i++)
        {
            if (movies[i].Id == id)
            {
                movies.RemoveAt(i);

                Console.WriteLine(
                    "Movie Deleted Successfully");

                return;
            }
        }

        Console.WriteLine("Movie Not Found");
    }


    // Edit movie
    public static void EditMovie(List<Movie> movies)
    {
        int id;

        while (true)
        {
            Console.Write("Enter Movie ID: ");

            if (int.TryParse(Console.ReadLine(), out id) &&
                id > 0)
            {
                break;
            }

            Console.WriteLine("Invalid ID");
        }


        int newPrice;

        for (int i = 0; i < movies.Count; i++)
        {
            if (movies[i].Id == id)
            {
                Console.Write("Enter New Movie Name: ");
                string newName = Console.ReadLine();


                while (true)
                {
                    Console.Write("Enter New Price: ");

                    if (int.TryParse(
                        Console.ReadLine(),
                        out newPrice) &&
                        newPrice >= 0)
                    {
                        break;
                    }

                    Console.WriteLine(
                        "Invalid Price! Price must contain only numbers.");
                }


                movies[i].Name = newName;
                movies[i].Price = newPrice;

                Console.WriteLine(
                    "Movie Edited Successfully");

                return;
            }
        }

        Console.WriteLine("Movie Not Found");
    }
}