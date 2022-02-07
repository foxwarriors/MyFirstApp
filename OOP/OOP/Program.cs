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

            Passenger p2 = new Passenger();
            p2.ID = "1112312";
            p2.Name = "Costelino Bijulino";
            p2.TicketID = "31312332";
            p2.MealType = "Carnivora";
            p2.HandBaggage = 3;
            p2.Baggage = 2;

            Flight f = new Flight();
            f.Passengers = new Passenger[] { p1, p2 };

            Console.WriteLine("Pasager 1: " + f.Passengers[0].Name);

            Console.WriteLine("Pasager 2: " + f.Passengers[1].Name);
        }

    }
}