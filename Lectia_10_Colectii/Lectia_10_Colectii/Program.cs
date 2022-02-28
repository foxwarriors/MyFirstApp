using System;
using System.Collections.Generic;
using System.Collections;
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

        public void runStacks()
        {
            Stack<Person> people = new Stack<Person>();

            people.Push(new Person { ID = "1", Name = "Mircea" });
            people.Push(new Person { ID = "2", Name = "Mihai" });
            people.Push(new Person { ID = "3", Name = "Paul" });
            people.Push(new Person { ID = "4", Name = "Florin" });

            Console.WriteLine(people.Pop().Name);
            Console.WriteLine(people.Pop().Name);

            people.Push(new Person { ID = "5", Name = "Costica" });

            Console.WriteLine(people.Peek().Name);
            Console.WriteLine(people.Pop().Name);
            Console.WriteLine(people.Count);

        }

        public void runDictionaries()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "John");
            dict.Add(2, "Alex");
            dict.Add(3, "Catalin");
            dict.Add(4, "Adi");
            dict.Add(5, "Ion");

            Console.WriteLine(dict.Count);
            foreach (KeyValuePair<int, string> pair in dict)
            {
                Console.WriteLine(pair.Key + ". " + pair.Value);
            }

            if(dict.ContainsKey(1))
            {
                dict[1] = "Piftel";
            }
            Console.WriteLine("------------");
            foreach (KeyValuePair<int, string> pair in dict)
            {
                Console.WriteLine(pair.Key + ". " + pair.Value);
            }
        }


        public void sortedList()
        {
            SortedList<int, Person> people = new SortedList<int, Person>();

            people.Add(5, new Person { Name = "Giani" });
            people.Add(1, new Person { Name = "Eduard" });
            people.Add(4, new Person { Name = "Matei" });
            people.Add(3, new Person { Name = "Dorel" });
            people.Add(2, new Person { Name = "Titus" });

            for(int i=0;i < people.Count;i++)
            {
                Console.WriteLine(people.Keys[i] + ". " + people.Values[i].Name);
            }
            people.Remove(3); //remove la cheia nr 3 
            Console.WriteLine("----After remove");
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people.Keys[i] + ". " + people.Values[i].Name);
            }

            people.RemoveAt(0); // remove la pozitia 0
            Console.WriteLine("----After remove at index 0");
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people.Keys[i] + ". " + people.Values[i].Name);
            }
        }

        public void runArrayList()
        {
            ArrayList al = new ArrayList();
            al.Add(1);
            al.AddRange(new List<int> { 5, 3, 2, 4, 6 });

            Console.WriteLine($"Capacity: {al.Capacity}, Count:{al.Count}");
            for(int i = 0; i < al.Count;i++)
            {
                Console.WriteLine(al[i]);
            }

            al.RemoveAt(0);

            Console.WriteLine("After remove");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

            Console.WriteLine($"Indexul lui 4 este {al.IndexOf(4)}");
            al.Reverse();
            Console.WriteLine("After reverse");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
        }

        public void runBitArrays()
        {
            BitArray b1 = new BitArray(new bool[] { true, false, true, true, false });
            BitArray b2 = new BitArray(new bool[] { true, false, false, true, true });

            BitArray and = b1.And(b2);
            BitArray or = b1.Or(b2);

            Show(and);
            Console.WriteLine("------");
            Show(or);
            
        }
        public static void Show(BitArray ba)
        {
            for(int i = 0; i< ba.Length; i++)
            {
                Console.WriteLine(ba[i]);
            }
        }

        public void runHashTable()
        {
            Hashtable nota = new Hashtable();
            nota.Add("Nadia", 23);
            nota.Add("Sorin", 40);
            nota.Add("Paul", 15);
            nota.Add("Robert", 51);

            Console.WriteLine(nota["Paul"]);

            if(nota.ContainsKey("Nadia"))
            {
                nota["Nadia"] = 30;
                Console.WriteLine("Nadia: " + nota["Nadia"]);
            }
            nota.Remove("Paul");
            Console.WriteLine(nota.Count);
        }

        public void runNGQueues()
        {
            Queue q = new Queue();
            q.Enqueue(new Person { ID = "1", Name = "Vasile" });
            q.Enqueue(new Person { ID = "2", Name = "Moga" });
            q.Enqueue(new Person { ID = "3", Name = "Bobi" });
            q.Enqueue(new Person { ID = "4", Name = "Dio" });

            Person p;
            p = q.Dequeue() as Person;
            Console.WriteLine(p.Name);
            p = q.Dequeue() as Person;
            Console.WriteLine(p.Name);
            p = q.Dequeue() as Person;
            Console.WriteLine(p.Name);
            p = q.Dequeue() as Person;
            Console.WriteLine(p.Name);

            q.Enqueue(new Person { ID = "5", Name = "Horia" });

            p = q.Peek() as Person;

            Console.WriteLine(p.Name);

            p = q.Dequeue() as Person;
            Console.WriteLine(p.Name);
            Console.WriteLine(q.Count);
        }

        public void runNGStacks()
        {
            Stack people = new Stack();

            people.Push(new Person { ID = "1", Name = "Mircea" });
            people.Push(new Person { ID = "2", Name = "Mihai" });
            people.Push(new Person { ID = "3", Name = "Paul" });
            people.Push(new Person { ID = "4", Name = "Florin" });

            Person p = new Person();

            p = people.Pop() as Person;
            Console.WriteLine(p.Name);
            p = people.Pop() as Person;
            Console.WriteLine(p.Name);

            people.Push(new Person { ID = "5", Name = "Josh" });
            Console.WriteLine(people.Count);

            p = people.Peek() as Person;
            Console.WriteLine(p.Name);
            p = people.Pop() as Person;
            Console.WriteLine(p.Name);

        }

        public void runNGSortedList()
        {
            SortedList top = new SortedList();

            top.Add(5, "EEE");
            top.Add(1, "AAA");
            top.Add(3, "CCC");
            top.Add(2, "BBB");
            top.Add(4, "DDD");

            for(int i = 0; i < top.Count; i++)
            {
                string position = top.GetKey(i).ToString();
                Console.WriteLine(position + ". " + top.GetByIndex(i));
            }

            top.RemoveAt(0);
            top.Remove(5);
            for (int i = 0; i < top.Count; i++)
            {
                string position = top.GetKey(i).ToString();
                Console.WriteLine(position + ". " + top.GetByIndex(i));
            }
        }

        public void CustomGenericClass()
        {
            //acelasi principiu si pentru string, etc.
            CustomCollection<int> numere = new CustomCollection<int>();
            numere.Add(1);
            numere.Add(7);
            numere.Add(9);

            numere.Show();
            numere.Remove(9);
            numere.Show();
        }
            

        static void Main(string[] args)
        {
            Program program = new Program();

            program.RunLists();
            program.runQueues();
            Console.WriteLine("----------STACKS-----------");
            program.runStacks();

            Console.WriteLine("----Dictionary----");
            program.runDictionaries();

            Console.WriteLine("----SortedList----");
            program.sortedList();

            Console.WriteLine("----ArrayList----");
            program.runArrayList();

            Console.WriteLine("----BitArray----");
            program.runBitArrays();

            Console.WriteLine("----HashTable----");
            program.runHashTable();

            Console.WriteLine("----NG Queues----");
            program.runNGQueues();

            Console.WriteLine("----NG Stacks----");
            program.runNGStacks();

            Console.WriteLine("----NG SortedList----");
            program.runNGSortedList();

            Console.WriteLine("----Custom Generic Class-----");
            program.CustomGenericClass();
        }
    }
}

public class Person
{
    public string Name;
    public string ID;
}

public class CustomCollection<T>
{
    List<T> list;

    public CustomCollection()
    {
        list = new List<T>();
    }

    public void Add(T newItem)
    {
        list.Add(newItem);
        Console.WriteLine("Added " + newItem + ", list has: " + list.Count + " items");
    }

    public void Remove(T toRemove)
    {
        list.Remove(toRemove);
        Console.WriteLine("Removed " + toRemove + ", list has: " + list.Count + " items");
    }

    public void Show()
    {
        for (int i = 0; i<list.Count;i++)
        {
            Console.WriteLine(list[i]);
        }
    }
}