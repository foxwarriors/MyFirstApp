using System;
using Lesson6;
namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Passenger p1 = new Passenger();
            p1.ID = "12312";
            p1.Name = "Costel Biju";
            p1.TicketID = "313132";
            p1.MealType = "Vegetarian";
            p1.HandBaggage = 1;
            p1.Baggage = 1;
            p1.SeatNumber = "12A";

            Passenger p2 = new Passenger();
            p2.ID = "1112312";
            p2.Name = "Costelino Bijulino";
            p2.TicketID = "31312332";
            p2.MealType = "Carnivora";
            p2.HandBaggage = 3;
            p2.Baggage = 2;
            p2.SeatNumber = "23C";

            Flight f = new Flight();
            f.Passengers = new Passenger[] { p1, p2 };

            Console.WriteLine("Pasager 1: " + f.Passengers[0].ToString());

            Console.WriteLine("Pasager 2: " + f.Passengers[1].ToString());


            Point a = new Point();
            Point b = new Point();
            a.X = 5;
            a.Y = 3;
            b.X = 6;
            b.Y = 4;

            Console.WriteLine("A: " + a.ToString());
            Console.WriteLine("B: " + b.ToString());

            Console.WriteLine("A=B?" + a.Equals(b));

            Console.WriteLine("A Hash Code: " + a.GetHashCode());
            Console.WriteLine("A Hash Code: " + b.GetHashCode());
        }

    }
}