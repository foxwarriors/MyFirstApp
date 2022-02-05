using System;
namespace OOP
{
    class Car
    {
        public string Brand;

        public string Model;

        public int AnConstructie;

        public string Culoare;

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
}
