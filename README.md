# Movie Booking System

A console-based **Movie Booking System** developed using **C# and .NET**.

The system allows users to view movies, select a movie, choose a time slot, view available seats, book seats, and perform CRUD operations on movies.

## Features

* View all movies
* Add a new movie
* Edit movie details
* Delete a movie
* Select a movie
* Select one of three time slots
* View seats for the selected movie and time slot
* Book multiple seats
* Prevent already booked seats from being booked again
* Separate seats for every movie and every time slot
* Input validation using `TryParse`

## Technologies Used

* C#
* .NET
* Console Application
* Object-Oriented Programming
* `List<T>`
* Arrays
* Methods
* Classes

## Project Structure

```text
MovieBookingSystem/
│
├── Program.cs
│
├── Models/
│   └── Movie.cs
│
├── Services/
│   ├── MovieService.cs
│   ├── BookingService.cs
│   └── MenuService.cs
│
├── MovieBookingSystem.csproj
│
├── README.md
└── .gitignore
```

## Modules

### Models

`Movie.cs`

Contains the movie information:

* Movie ID
* Movie name
* Movie price
* Three time slots
* Separate seats for each time slot

### MovieService

Handles movie CRUD operations:

* View movies
* Add movie
* Edit movie
* Delete movie

### BookingService

Handles booking-related operations:

* Select time slot
* View seats
* Book seats
* Check whether a seat is already booked

### MenuService

Handles:

* Main menu
* Movie selection
* Movie menu
* Navigation between different operations

### Program.cs

Contains the application's entry point and initializes the default movies.

## How the Booking Works

The user first selects a movie.

For example:

```text
1. KGF
2. RRR
3. Avengers
```

After selecting a movie, the user can select one of three time slots:

```text
1. 10:00 AM
2. 2:00 PM
3. 7:00 PM
```

Each time slot has its own set of 20 seats.

For example:

```text
KGF
│
├── 10:00 AM
│   └── 20 seats
│
├── 2:00 PM
│   └── 20 seats
│
└── 7:00 PM
    └── 20 seats
```

Therefore, booking Seat 5 for the 10:00 AM show does not book Seat 5 for the 2:00 PM show.

## Main Menu

```text
========== MOVIE BOOKING SYSTEM ==========

1. View Movies
2. Select Movie
3. Add Movie
4. Delete Movie
5. Edit Movie
0. Exit
```

## Example Movie Data

```text
ID: 1 | Name: KGF | Price: 200
ID: 2 | Name: RRR | Price: 180
ID: 3 | Name: Avengers | Price: 250
```

## Running the Project

Make sure .NET is installed on your computer.

Open the project folder in VS Code and run:

```bash
dotnet run
```

## Future Improvements

Possible future features include:

* Different time slots for each movie
* Customer details
* Booking ID
* Ticket generation
* Cancellation of bookings
* Payment system
* Database integration
* Login and authentication
* Graphical user interface

## Author

Chetan Nandgave
