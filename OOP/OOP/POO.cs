using System;
namespace OOP
{
    class Car
    {
        private string Brand;

        private string Model;

        private int AnConstructie;

        private string Culoare;

        public Car()
        {
            Brand = "-";
            Model = "-";
            AnConstructie = 2020;
            Culoare = "Gri";

        }

        public Car(string brand, string model, int anct, string culoare)
        {
            this.Brand = brand;
            this.Model = model;
            this.AnConstructie = anct;
            this.Culoare = culoare;
        }

        public string getCuloare()
        {
            return Culoare;
        }

        public string getBrand()
        {
            return Brand;
        }

        public int getAn()
        {
            return AnConstructie;
        }

        public string getModel()
        {
            return Model;
        }

        public void Start()
        {
            Console.WriteLine("Engine started");
        }

        public void Stop()
        {
            Console.WriteLine("Engine stopped");
        }

        public void Brake()
        {
            Console.WriteLine("Braked!");
        }
    }

    public class Person
    {
        protected string Name;

        protected string ID;
    }

    public class Student : Person
    {

        public Student(string name, string id)
        {
            this.Name = name;
            this.ID = id;
        }
        
        public string Domain;

        public int AnAbsolvire;

        public int[] Note;

        public void prezent()
        {
            Console.WriteLine($"Buna, ma numesc {this.Name}, ID :{this.ID}, sunt student la {this.Domain}");
        }

    }

    public class BankAccount
    {
        private double balance;

        public double Balance
        {
            get { return balance; }
        }

        public void ShowBalance()
        {
            Console.WriteLine("Your balance is " + Balance);
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }

    }

    public abstract class Animal
    {
        public abstract void MakeSound();
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }

    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    public abstract class Shape
    {

        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        public double l;
        public double L;

        public override double Area()
        {
            return L * l;

        }
    }
    public class Circle : Shape
    {
        public double pi = 3.14;
        public double r;

        public override double Area()
        {
            return pi * r * r;

        }

    }


    public class CalculatorSalariu
    {
        public static int NumarLuni = 12;

        public double SalariuAnual(double salariuLunar)
        {
            return salariuLunar * NumarLuni;

        }
    }

}
