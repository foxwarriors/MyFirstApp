using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


public class CustomComparer : IComparer
{
    public int Compare(object a, object b)
    {
        return ((new CaseInsensitiveComparer()).Compare(b, a));
    }
}

public class Student:IComparable<Student>
{
    public string Name;
    public string Domain;
    public double Grade;

    public int CompareTo(Student other)
    {
        if (this.Grade < other.Grade) return -1;
       else if (this.Grade == other.Grade)
        {
            return this.Name.CompareTo(other.Name);
        }
       return 1;
    }
}

public class Person
{
    public string Name;
    public string ID;
}

public class PeopleEnumerator : IEnumerator
{
    Person[] _people;
    int position = -1;

    public object Current
    {
        get
        {
            return CurrentElement;
        }
    }
    public Person CurrentElement
    {
        get
        {
            try
            {
                return _people[position];
            }

            catch(IndexOutOfRangeException exception)
            {
                throw exception;
            }
        }
    }
    public PeopleEnumerator(Person[] people)
    {
        _people = people;
    }


    public bool MoveNext()
    {
        position++;
        if (position < _people.Length)
            return true;
        return false;
    }

    public void Reset()
    {
        position = -1;
    }
}

public class People : IEnumerable
{
    private Person[] _people;

    public People(Person[] pArray)
    {
        _people = new Person[pArray.Length];
        for(int i = 0; i < pArray.Length; i ++)
        {
            _people[i] = pArray[i];
        }
    }

    public IEnumerator GetEnumerator()
    {
        return (IEnumerator)getMyEnumerator();
    }

    public PeopleEnumerator getMyEnumerator()
    {
        return new PeopleEnumerator(_people);
    }
}

namespace Lectia_11_SortareColectii
{
  
    class Program
    {
        public void testEnumerator()
        {
            Person[] peopleArray = new Person[3]
            {
                new Person { Name = "Adi"},
                new Person { Name = "Vasile"},
                new Person { Name = "John" }
            };
            People peoplelist = new People(peopleArray);
            foreach(Person p in peoplelist)
            {
                Console.WriteLine(p.Name);
            }
        }

        public void testComparable()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "John", Grade = 10, Domain = "Bio" });
            students.Add(new Student { Name = "Paul", Grade = 8, Domain = "Bio" });
            students.Add(new Student { Name = "Mihnea", Grade = 8, Domain = "Bio" });
            students.Add(new Student { Name = "Vlad", Grade = 9, Domain = "Bio" });

            for(int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"[{i}]" + students[i].Name + " " + students[i].Grade);
            }

            Console.WriteLine("--------------");
            students.Sort();

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"[{i}]" + students[i].Name + " " + students[i].Grade);
            }

        }

        public void testComparer()
        {
            string[] words = { "B", "C", "V", "E", "J", "L", "K", "a", "d", "P", "m" };

            for (int i = 0; i < words.Length; i++) 
            {
                Console.WriteLine($"[{i}] " + words[i]);
            }
            Console.WriteLine("--------");
            Array.Sort(words,new CustomComparer());
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"[{i}] " + words[i]);
            }
        }

        public void Linq()
        {
            List<int> scores = new List<int>();

            scores.AddRange(new int[] { 100, 2, 4, 7, 10, 81, 200 });
            //Query Syntax
            IEnumerable<int> scores1 =
                from score in scores
                where score > 80
                orderby score descending
                select score;
            foreach(int score in scores1)
            {
                Console.WriteLine(score);
            }

            //Method Syntax
            IEnumerable<int> scores2 = scores
                .Where(s => s > 80)
                .OrderByDescending(s => s)
                .Select(s => s);

            foreach (int score in scores2)
            {
                Console.WriteLine(score);
            }

            Console.WriteLine("-----");
            Console.WriteLine(scores.Max());
            Console.WriteLine(scores.Min());

            IEnumerable<string> messages = scores.Select(s => "..." + s);
            foreach (string message in messages)
                Console.WriteLine(message);

            Console.WriteLine("SUM: " + scores.Sum());

            Console.WriteLine("All >= 2 :" + scores.All(s => s >= 2));
            Console.WriteLine("All >= 50 :" + scores.All(s => s >= 50));
            Console.WriteLine("Any > 100? : " + scores.Any(s => s > 100));
            Console.WriteLine("Any < 2? : " + scores.Any(s => s < 2));

            Console.WriteLine("Average: " + scores.Average());

            Console.WriteLine("Count >= 100 : " + scores.Count(s => s >= 100));

            List<int> multiple = new List<int>();
            multiple.AddRange(new int[] { 2, 3, 5, 5, 10, 5, 2, 8, 5, 9, 23, 55, 23, 99, 43, 88, 87, 99, 101 });
            IEnumerable<int> noDuplicates = multiple.Distinct();
            Console.WriteLine("Numere in total: " + multiple.Count());
            Console.WriteLine("Numere Distincte: " + noDuplicates.Count());
            foreach (int n in noDuplicates)
                Console.Write(n + " ");
            Console.WriteLine("");

            List<Student> myStudents = new List<Student>();

            myStudents.Add(new Student { Name = "Ana", Grade = 7, Domain = "Bio" });
            myStudents.Add(new Student { Name = "Vio", Grade = 8, Domain = "Info" });
            myStudents.Add(new Student { Name = "John", Grade = 6, Domain = "Info" });
            myStudents.Add(new Student { Name = "Costache", Grade = 8, Domain = "Fr" });
            myStudents.Add(new Student { Name = "Mircea", Grade = 9.3, Domain = "Ef" });
            myStudents.Add(new Student { Name = "Piftel", Grade = 7.6, Domain = "Bio" });

            Student s1 = myStudents.FirstOrDefault(s => s.Grade > 9);
            if (s1 != null)
                Console.WriteLine(s1.Name);

            else
                Console.WriteLine("No student found.");

          var studentsByDomain = myStudents.GroupBy(s => s.Domain, s => s.Name);

           foreach(var domain in studentsByDomain)
            {
                string studentNames = string.Join(", ", domain.ToList());
                Console.WriteLine($"Key = {domain.Key} Names= {studentNames}");
            }

            Student last = myStudents.LastOrDefault(s => s.Grade > 9);
            if (last != null)
                Console.WriteLine("Last student with grade > 9 " + last.Name);

            else
                Console.WriteLine("No student found.");

            var studentDescByGrade = myStudents.OrderByDescending(s => s.Grade);
            foreach (Student s in studentDescByGrade)
                Console.WriteLine(s.Grade + "-" + s.Name);

            var minusF3 = myStudents.Skip(3);
            foreach (Student s in minusF3)
                Console.WriteLine(s.Name);
            Console.WriteLine("--------");
            var take3 = myStudents.Take(3);
            foreach (Student s in take3)
                Console.WriteLine(s.Name);
            Console.WriteLine("-------");
            var skip2take3 = myStudents.Skip(2).Take(3);
            foreach (Student s in skip2take3)
                Console.WriteLine(s.Name);
            Console.WriteLine("Primii studenti cu media sub 9: ");
            var lessThan9 = myStudents.TakeWhile(s => s.Grade < 9);
            foreach (Student s in lessThan9)
                Console.WriteLine(s.Name);

            var ordered = myStudents.OrderByDescending(s => s.Grade)
                .ThenBy(s => s.Name);

            foreach (Student s in ordered)
                Console.WriteLine(s.Grade + "-" + s.Name);

            var students = myStudents.ToArray();

            Console.WriteLine("Afisarea arrayului de studenti: ");

            for(int i = 0; i < students.Length;i ++)
            {
                Console.WriteLine(i + ". " + students[i].Name);
            }

            Dictionary<string, Student> ds = myStudents.ToDictionary(s => s.Name);

            foreach(var pair in ds)
            {
                Console.WriteLine("Key: " + pair.Key + ", Value: " + pair.Value);
            }
        }


        static void Main(string[] args)
        {
            Program test = new Program();

            test.testEnumerator();
            test.testComparable();
            test.testComparer();
            test.Linq();
        }
    }
}
