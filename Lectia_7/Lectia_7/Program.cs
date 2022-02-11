using System;

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

            p = (Parent)c;



            Console.WriteLine(p.Name);
            Console.WriteLine(a);

        }
    }
}
