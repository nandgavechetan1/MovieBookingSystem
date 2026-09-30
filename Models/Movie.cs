namespace MovieBookingSystem.Models;

class Movie
{
    public int Id;
    public string Name;
    public int Price;

    public bool[][] Seats;
    public string[] TimeSlots;

    public Movie(int id, string name, int price)
    {
        Id = id;
        Name = name;
        Price = price;

        // Three time slots
        TimeSlots = new string[3];

        TimeSlots[0] = "10:00 AM";
        TimeSlots[1] = "2:00 PM";
        TimeSlots[2] = "7:00 PM";

        // Three separate seat arrays
        Seats = new bool[3][];

        Seats[0] = new bool[20];
        Seats[1] = new bool[20];
        Seats[2] = new bool[20];
    }
}