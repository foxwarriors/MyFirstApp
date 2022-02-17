using System;
using System.IO;
using System.Text;

namespace Lectia_9_StreamDeObiecte
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathDogs = @"/Users/adrianciuca/Desktop/Hello.txt";
            using (FileStream stream = new FileStream(pathDogs, FileMode.Open, FileAccess.Write))
            {
                Dog myDog = new Dog() { Breed = "Samoyed", Name = "Fluffy", Age = 5 };

                string dogAsString = myDog.ToText();

                byte[] data = Encoding.UTF8.GetBytes(dogAsString);
                stream.Write(data, 0, data.Length);
            }
            Console.WriteLine("am terminat scrierea in fisierul: " + pathDogs);

            using (FileStream stream = new FileStream(pathDogs, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[stream.Length];
                int streamLength = (int)stream.Length;

                stream.Read(bytes, 0, streamLength);

                string stringFromFile = Encoding.UTF8.GetString(bytes);

                Dog myDog = Dog.FromText(stringFromFile);
                Console.WriteLine("Din fisier, am reconstruit urmatorul obiect dog:");
                Console.WriteLine("Name:" + myDog.Name);
                Console.WriteLine("Breed:" + myDog.Breed);
                Console.WriteLine("Age:" +myDog.Age);
            }
        }
    }
}


public class Dog
{
    public string Name;
    public int Age;
    public string Breed;
    public Dog() { }

    public string ToText()
    {
        return this.Name + "-" + this.Breed + "-" + this.Age;
    }

    public static Dog FromText(string text)
    {
        //Fluffy-Samoyed-5
        string[] parts = text.Split('-');
        Dog d = new Dog();
        d.Name = parts[0];
        d.Breed = parts[1];
        d.Age = int.Parse(parts[2]);

        return d;
    }
}