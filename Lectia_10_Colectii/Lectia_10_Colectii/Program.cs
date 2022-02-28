using System;
using System.Collections.Generic;
namespace Lectia_10_Colectii
{
    class Program
    {
        public void RunLists()
        {
            List<string> names = new List<string>();
            names.Add("Maria");
            names.Add("Viorel");
            names.Add("Adi");
            names.Add("Marius");

            Console.WriteLine(names.Count);
            Console.WriteLine(names.Capacity);

            for(int i = 0; i < names.Count; i ++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("-----------");
            names.Remove("Maria");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("-----------");
            List<string> lista = new List<string> { "Luca", "Matei" };
            names.AddRange(lista);

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

        }

        public void runQueues()
        {
            Console.WriteLine("-----------Queues----------");
            Queue<Person> people = new Queue<Person>();
            people.Enqueue(new Person { ID = "1", Name = "Giani" });
            people.Enqueue(new Person { ID = "2", Name = "Veorica" });
            people.Enqueue(new Person { ID = "3", Name = "Mirel" });
            people.Enqueue(new Person { ID = "4", Name = "Gigel" });

            Console.WriteLine(people.Dequeue().Name);
            Console.WriteLine(people.Dequeue().Name);
            Console.WriteLine(people.Dequeue().Name);

            people.Enqueue(new Person { ID = "5", Name = "Costel" });
            Console.WriteLine(people.Dequeue().Name);
            Console.WriteLine(people.Dequeue().Name);

            people.Enqueue(new Person { ID = "6", Name = "Alex" });
            Console.WriteLine("PEEK: " + people.Peek().Name);
            Console.WriteLine("DEQUEUE: " + people.Dequeue().Name);
            Console.WriteLine(people.Count);

        }

        static void Main(string[] args)
        {
            Program program = new Program();

            program.RunLists();

            program.runQueues();
        }
    }
}

public class Person
{
    public string Name;
    public string ID;
}