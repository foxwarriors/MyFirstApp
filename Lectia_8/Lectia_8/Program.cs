using System;


namespace Lectia_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Snippet 1 - exemplu de try catch and finally
            /*try
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
            */


            Card MyCard = new Card { Owner = new Client { Name = "Viorel", yearOfBirth = 2005 } };

            shop.Buy("cigarettes, gum, milk, bread", MyCard);

        }
    }
}


public static class shop
{
    public static void Buy(string itemsInCart, Card card)
    {
        if(card.Owner.Age < 18 && itemsInCart.Contains("cigar"))
        {
            throw new SaleNotPermittedException("Este nepermisa vanzarea de tutun catre minori");
        }
        else
        {
            Console.WriteLine("Va mai asteptam!");

        }
    }
}

public class Card
{
    public Client Owner;

}

public class Client
{
    public string Name;
    public int yearOfBirth;
    public int Age
    {
        get
        {
            return DateTime.Now.Year - yearOfBirth;
        }
    }
}

public class SaleNotPermittedException : Exception
{
    public SaleNotPermittedException(string msg) : base(msg)
    {

    }
}