using System;

namespace Lectia_8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CalculateAndShowAge(192);

            }

            catch (Exception e)
            {
                Console.WriteLine("am gasit exceptia: " + e.Message);
            }
        }

        public static void CalculateAndShowAge(int yearOfBirth)
        {
            try
            {

                int age = CalculateAge(yearOfBirth);
                ShowAge(age);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }


        }

        public static int CalculateAge(int yearOfBirth)
        {
            if(yearOfBirth < 0)
            {
                throw new ArgumentException("Anul nasterii nu poate sa fie negativ!");
            }
            if(yearOfBirth <= 1900)
            {
                throw new Exception("Esti sigur?");
            }
            int yearNow = DateTime.Now.Year;
            int age = yearNow - yearOfBirth;
            return age;
        }

        public static void ShowAge(int age)
        {
            Console.WriteLine(age);
        }

    }
}
