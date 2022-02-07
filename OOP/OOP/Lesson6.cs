using System;
namespace Lesson6
{
         public class Vehicle
        {
        public string Make;
        public string Model;
        public int YearBuilt;

        public override string ToString()
        {
            return base.ToString();
        }

    }

    public class Car : Vehicle
    {
        public int NrDoors;
        public int MaxPersonCapacity;
        public string FuelType;

    }

    public class ElectricCar : Car
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

        public override string ToString()
        {
            return this.Name + "-" + this.ID + "-" + TicketID + "-" + this.SeatNumber + "-" +
                this.MealType + "-" + this.Baggage + "-" + this.HandBaggage;


        }

    }

    public class Flight
    {
        public Passenger[] Passengers;
    }

    public class Point
    {
        public int X;
        public int Y;

        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }

        public override bool Equals(object obj)
        {
            Point B = obj as Point;

            return this.X == B.X && this.Y == B.Y;
        }

        public override int GetHashCode()
        {
            return this.X + this.Y;
        }

    }
}
