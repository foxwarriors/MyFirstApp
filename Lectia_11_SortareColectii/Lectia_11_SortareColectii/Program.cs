using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
        static void Main(string[] args)
        {
            Program test = new Program();

            test.testEnumerator();
        }
    }
}
