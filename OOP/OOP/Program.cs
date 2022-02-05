using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Car x = new Car();
            x.AnConstructie = 2018;
            x.Brand = "Mercedes";
            x.Culoare = "Rosu";
            x.Model = "S Klasse";

            Car x1 = new Car();
            x1.AnConstructie = 2020;
            x1.Brand = "BMW";
            x1.Culoare = "Negru";
            x1.Model = "X6";

            x.Start();
            x1.Start();

            x.Brake();
            x1.Brake();

            x1.Stop();

            Console.WriteLine($"The car is a {x.Brand} {x.Model} and it was built in {x.AnConstructie}");
            Console.WriteLine($"The car is a {x1.Brand} {x1.Model} and it was built in {x1.AnConstructie}");
        }
    }
}
