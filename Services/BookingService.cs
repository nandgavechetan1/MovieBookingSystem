using MovieBookingSystem.Models;

namespace MovieBookingSystem.Services;

class BookingService
{
    // Select one of the three time slots
    public static int SelectTimeSlot(Movie movie)
    {
        int choice;

        Console.WriteLine("\n========== TIME SLOTS ==========");

        Console.WriteLine(
            "1. " + movie.TimeSlots[0]);

        Console.WriteLine(
            "2. " + movie.TimeSlots[1]);

        Console.WriteLine(
            "3. " + movie.TimeSlots[2]);

        Console.WriteLine("===============================");


        while (true)
        {
            Console.Write("Enter Time Slot: ");

            if (int.TryParse(
                Console.ReadLine(),
                out choice) &&
                choice >= 1 &&
                choice <= 3)
            {
                return choice - 1;
            }

            Console.WriteLine(
                "Invalid Time Slot! Enter 1, 2 or 3.");
        }
    }


    // View seats for selected movie and slot
    public static void ViewSeats(Movie movie, int slot)
    {
        Console.WriteLine("\n========== SEATS ==========");

        Console.WriteLine(
            "Movie: " + movie.Name);

        Console.WriteLine(
            "Time: " + movie.TimeSlots[slot]);

        Console.WriteLine();


        for (int i = 0;
             i < movie.Seats[slot].Length;
             i++)
        {
            if (movie.Seats[slot][i] == false)
            {
                Console.Write(
                    "[" + (i + 1) + "]  ");
            }
            else
            {
                Console.Write("[X]  ");
            }


            if ((i + 1) % 5 == 0)
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine("============================");
    }


    // Book seats
    public static void BookSeats(Movie movie, int slot)
    {
        int total = 0;

        Console.WriteLine("\n========== BOOK SEATS ==========");

        Console.WriteLine(
            "Movie: " + movie.Name);

        Console.WriteLine(
            "Time: " + movie.TimeSlots[slot]);

        Console.WriteLine(
            "Price: " + movie.Price);

        Console.WriteLine("===============================");


        int n;

        while (true)
        {
            Console.Write("Enter Number of Seats: ");

            if (int.TryParse(
                Console.ReadLine(),
                out n) &&
                n > 0 &&
                n <= movie.Seats[slot].Length)
            {
                break;
            }

            Console.WriteLine(
                "Invalid Number of Seats!");
        }


        for (int i = 0; i < n; i++)
        {
            int seat;

            while (true)
            {
                Console.Write(
                    "Enter Seat Number " +
                    (i + 1) + ": ");


                if (int.TryParse(
                    Console.ReadLine(),
                    out seat) &&
                    seat > 0 &&
                    seat <= movie.Seats[slot].Length)
                {
                    if (movie.Seats[slot][seat - 1] == true)
                    {
                        Console.WriteLine(
                            "Seat " + seat +
                            " is Already Booked");

                        continue;
                    }

                    break;
                }

                Console.WriteLine(
                    "Invalid Seat Number");
            }


            movie.Seats[slot][seat - 1] = true;

            total = total + movie.Price;
        }


        Console.WriteLine("\n================================");
        Console.WriteLine("       BOOKING SUCCESSFUL");
        Console.WriteLine("================================");

        Console.WriteLine(
            "Movie: " + movie.Name);

        Console.WriteLine(
            "Time: " + movie.TimeSlots[slot]);

        Console.WriteLine(
            "Tickets: " + n);

        Console.WriteLine(
            "Price Per Ticket: " + movie.Price);

        Console.WriteLine(
            "Total Price: " + total);

        Console.WriteLine("================================");
    }
}