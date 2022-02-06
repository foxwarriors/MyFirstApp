using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Car x = new Car("Mercedes", "S Klasse", 2020, "Rosu");
           /* x.AnConstructie = 2018;
            x.Brand = "Mercedes";
            x.Culoare = "Rosu";
            x.Model = "S Klasse";*/

            Car x1 = new Car("BMW","X6", 2021, "Negru");
            /*x1.AnConstructie = 2020;
            x1.Brand = "BMW";
            x1.Culoare = "Negru";
            x1.Model = "X6";*/

            x.Start();
            x1.Start();

            x.Brake();
            x1.Brake();

            x1.Stop();

            Console.WriteLine($"The car is a {x.getBrand()} {x.getModel()} and it was built in {x.getAn()}");
            Console.WriteLine($"The car is a {x1.getBrand()} {x1.getModel()} and it was built in {x1.getAn()}");

            Student s = new Student("Viorel Versace", "vx66");
            s.Domain = "IT";
            s.prezent();

            BankAccount ba = new BankAccount();
            ba.Deposit(100);
            ba.Withdraw(20);

            ba.ShowBalance();


            Cat cat = new Cat();
            Dog dog = new Dog();

            cat.MakeSound();
            dog.MakeSound();

            Calculator calc = new Calculator();

            Console.WriteLine(calc.Add(5, 10) + " " + calc.Add(3, 11, 4));

            Rectangle rec = new Rectangle();
            rec.l = 5;
            rec.L = 10;

            Circle ci = new Circle();
            ci.r = 3;

            Console.WriteLine( rec.Area());
            Console.WriteLine(ci.Area());

            CalculatorSalariu cs = new CalculatorSalariu();
            Console.WriteLine($"Salariul meu anual este de {cs.SalariuAnual(3000)} lei");

        }

    }
}