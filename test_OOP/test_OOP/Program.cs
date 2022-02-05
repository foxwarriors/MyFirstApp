using System;

namespace test_OOP
{
    public class person
    {
        public string name;
        public string IDcard;
    }
        public class student: person
        {
            public string domeniu;
            public int[] note;
        }
        
    class Program
    {
        static void Main()
        {
            student x = new student();
            x.name = "viorel";
            x.IDcard = "vx69";
            x.domeniu = "IT";

            Console.WriteLine(x.name + " " + x.IDcard + " " + x.domeniu);
        }
    }
}
