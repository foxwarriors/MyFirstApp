using System;
namespace Lesson6
{
    public interface IVehicle
    {
        void Start();
        void Stop();
        void Brake();
        void ShowSpeed();
    }


         public class Vehicle : IVehicle
        {
        public string Make;
        public string Model;
        public int YearBuilt;

        public void Brake()
        {
            Console.WriteLine("Brake");
        }

        public void ShowSpeed()
        {
            Console.WriteLine("ShowSpeed");
        }

        public void Start()
        {
            Console.WriteLine("Start");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }

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
        public double TankCapacity;
        public double TankLevel;

        public virtual void Start()
        {
            Console.WriteLine("Hello, welcome!" + $"You have {(TankLevel/TankCapacity) * 100} % fuel left!" );
        }

    }

    public class ElectricCar : Car
    {
        public double BatteryCapacity;

        public override void Start()
        {
            Console.WriteLine($"Hello, welcome! You have {BatteryCapacity} % left!");
        }
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

        public override string ToString()
        {
            return this.ID + "-" + this.Name;
        }
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
            return base.ToString() + "-" + TicketID + "-" + this.SeatNumber + "-" +
                this.MealType + "-" + this.Baggage + "-" + this.HandBaggage;


        }

    }

    public class Flight
    {
        public Passenger[] Passengers;
    }

    public class Point : IComparable<Point>
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

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

         public int CompareTo(Point other)
        {
            if (this.X == other.X && this.Y == other.Y)
                return 0;
            else if (this.X > other.X && this.Y > other.Y)
                return 1;
            else if (this.X < other.X && this.Y < other.Y)
                return -1;

            return 0;
        }

        public static bool operator > (Point p1, Point p2)
        {
            return p1.CompareTo(p2) > 0;
        }

        public static bool operator < (Point p1, Point p2)
        {
            return p1.CompareTo(p2) < 0;
        }
    }

    public class Clock
    {
        public int Hour;
        public int Minute;

        public Clock()
        {
            Hour = 12;
            Minute = 0;
        }
    }

    public class ClockWithWeather : Clock
    {
        public int Temperature;

        public ClockWithWeather() : base()
        {
            Temperature = 0;

        }
    }

    public abstract class Shape
    {
        public abstract double Area();

        public abstract double MyArea
        {
            get;
        }

    }

    public class Square : Shape
    {
        public double Latura;
        public override double MyArea
        {
            get
            {
                return Latura * Latura;
            }
        }
        public override double Area()
        {
            return Latura * Latura;
        }
    }


}
