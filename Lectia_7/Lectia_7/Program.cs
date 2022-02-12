using System;
using System.Globalization;

namespace Lectia_7
{

    public class Parent
    {
        public string Name;


    }

    public class Child : Parent { }

    class Program
    {
        static void Main(string[] args)
        {

            int a = 20;
            double b = 6.7777;

            a = (int)b;

            Parent p = new Parent() { Name = "Bob" };
            Child c = new Child() { Name = "Viorel" };

            // p = (Parent)c;

            Console.WriteLine(a);

            Console.WriteLine(p.Name);
            Console.WriteLine(c.Name);


            if (p is Parent)
            {
                Parent p2 = p as Parent;
                Console.WriteLine(p2.Name);
            }

            if (p.GetType() == typeof(Parent))
            {
                Console.WriteLine("typeof p = Parent");
            }

            string num = "2";
            string num1 = "3.5";
            string num2 = "abc";
            string num3 = "10-11-2020";

            double d = double.Parse(num1);
            //d = double.Parse(num2); eroare

            DateTime dt = DateTime.Parse(num3, new CultureInfo("ro-RO"));
            // dt = DateTime.Parse(num); eroare

            Console.WriteLine($"Luna: {dt.Month}");

            int res;
            bool r = int.TryParse(num, out res);
            if (r)
            {
                Console.WriteLine("Parsare reusita: " + res);
            }
            else
            {
                Console.WriteLine("Parsare nereusita");
            }


            Parent p3 = null;
            if (p3 is null)
            {
                p3 = new Parent() { Name = "John" };
                Console.WriteLine("Created John");
            }

            Parent p4 = null;
            Parent p5 = p4 ?? p3;

            Console.WriteLine(p5.Name);

            int t = Convert.ToInt32("2");
            Console.WriteLine(t);

            string datestring = "07-08-2021";
            DateTime rez = Convert.ToDateTime(datestring, new CultureInfo("ro-RO"));

            Console.WriteLine($"Ziua:{rez.Day} Luna:{rez.Month} Anul:{rez.Year}");

            decimal dec = Convert.ToDecimal("4,8", new CultureInfo("ro-RO"));
            Console.WriteLine(dec);


        }
    }
}
