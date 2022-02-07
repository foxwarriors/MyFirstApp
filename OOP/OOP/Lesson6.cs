using System;
namespace Lesson6
{
         public class Vehicle
        {
        public string Make;
        public string Model;
        public int YearBuilt;

        }

    public class Car : Vehicle
    {
        public int NrDoors;
        public int MaxPersonCapacity;
        public string FuelType;

    }

    public class ElectricCar:Vehicle
    {
        public double BatteryCapacity;
    }

    public class Bike:Vehicle
    {
        public int NrSpeeds;
        public string UsageType;
    }


    public class Bus:Vehicle
    {
        public int seats;
    }

    public class Truck:Vehicle
    {
        public double MaxFreight;
    }


    public class Person
    {
        public string ID;
        public string Name;

    }

    public class Passenger:Person
    {
        public string TicketID;
        public string SeatNumber;
        public string MealType;
        public int Baggage;
        public int HandBaggage;
    }

    public class Flight
    {
        public Passenger[] Passengers;
    }
}
