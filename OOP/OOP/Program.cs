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

            Lesson6.Car car = new Lesson6.Car();
            car.TankLevel = 10;
            car.TankCapacity = 50;
            car.Start();

            ElectricCar ec = new ElectricCar();
            ec.BatteryCapacity = 70;
            ec.Start();

            Lesson6.Person person1 = new Lesson6.Person();
            person1.ID = "vx55";
            person1.Name = "Viorel Mirel";

            Passenger passenger1 = new Passenger();
            passenger1.TicketID = "1231ws";
            passenger1.Name = "titel costel";
            passenger1.MealType = "veggy";
            passenger1.HandBaggage = 2;
            passenger1.Baggage = 0;
            passenger1.SeatNumber = "23e";

           Console.WriteLine(person1.ToString());
           Console.WriteLine(passenger1.ToString());


            Clock cl = new Clock();
            ClockWithWeather clw = new ClockWithWeather();

            Console.WriteLine(cl.Hour +" "+ cl.Minute);
            Console.WriteLine(clw.Hour +" "+ clw.Minute + " " + clw.Temperature);


            Square sq = new Square();
            sq.Latura = 5;
            Console.WriteLine(sq.Area());
            Console.WriteLine(sq.MyArea);

            Point pt1 = new Point(1, 6);
            Point pt2 = new Point(2, 8);


            Console.WriteLine(pt1 < pt2);
            Console.WriteLine(pt1 > pt2);
        }

    }
}