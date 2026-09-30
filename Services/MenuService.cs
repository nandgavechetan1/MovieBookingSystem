using MovieBookingSystem.Models;

namespace MovieBookingSystem.Services;

class MenuService
{
    // Select movie
    public static void SelectMovie(List<Movie> movies)
    {
        MovieService.ViewMovies(movies);

        int id;

        while (true)
        {
            Console.Write("Enter Movie ID: ");

            if (int.TryParse(
                Console.ReadLine(),
                out id) &&
                id > 0)
            {
                break;
            }

            Console.WriteLine(
                "Invalid ID! Enter a positive number.");
        }


        foreach (Movie movie in movies)
        {
            if (movie.Id == id)
            {
                int slot =
                    BookingService.SelectTimeSlot(movie);

                MovieMenu(movie, slot);

                return;
            }
        }

        Console.WriteLine("Movie Not Found");
    }


    // Menu after selecting movie and time slot
    public static void MovieMenu(Movie movie, int slot)
    {
        int choice;

        do
        {
            Console.WriteLine("\n========== MOVIE ==========");

            Console.WriteLine(
                "Movie: " + movie.Name);

            Console.WriteLine(
                "Time: " + movie.TimeSlots[slot]);

            Console.WriteLine(
                "Price: " + movie.Price);

            Console.WriteLine();

            Console.WriteLine("1. View Seats");
            Console.WriteLine("2. Book Seats");
            Console.WriteLine("0. Exit");

            Console.WriteLine("===========================");


            while (true)
            {
                Console.Write("Enter Choice: ");

                if (int.TryParse(
                    Console.ReadLine(),
                    out choice) &&
                    choice >= 0 &&
                    choice <= 2)
                {
                    break;
                }

                Console.WriteLine(
                    "Invalid Choice! Enter 0, 1 or 2.");
            }


            switch (choice)
            {
                case 1:

                    BookingService.ViewSeats(
                        movie,
                        slot);

                    break;


                case 2:

                    BookingService.BookSeats(
                        movie,
                        slot);

                    break;


                case 0:

                    Console.WriteLine(
                        "Returning to Main Menu");

                    break;
            }

        } while (choice != 0);
    }


    // Main menu
    public static void MainMenu(List<Movie> movies)
    {
        int choice;

        do
        {
            Console.WriteLine("\n========== MOVIE BOOKING SYSTEM ==========");

            Console.WriteLine("1. View Movies");
            Console.WriteLine("2. Select Movie");
            Console.WriteLine("3. Add Movie");
            Console.WriteLine("4. Delete Movie");
            Console.WriteLine("5. Edit Movie");
            Console.WriteLine("0. Exit");

            Console.WriteLine(
                "==========================================");


            while (true)
            {
                Console.Write("Enter Choice: ");

                if (int.TryParse(
                    Console.ReadLine(),
                    out choice) &&
                    choice >= 0 &&
                    choice <= 5)
                {
                    break;
                }

                Console.WriteLine(
                    "Invalid Choice! Enter 0 to 5.");
            }


            switch (choice)
            {
                case 1:

                    MovieService.ViewMovies(movies);

                    break;


                case 2:

                    SelectMovie(movies);

                    break;


                case 3:

                    MovieService.AddMovie(movies);

                    break;


                case 4:

                    MovieService.DeleteMovie(movies);

                    break;


                case 5:

                    MovieService.EditMovie(movies);

                    break;


                case 0:

                    Console.WriteLine(
                        "Thank you for using Movie Booking System!");

                    break;
            }

        } while (choice != 0);
    }
}