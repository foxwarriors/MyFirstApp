using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!!!!!");

            Console.WriteLine("Here is my branch!");

            int[] numere = new int[] { 1, 8, 13, 21, 37, 41, 74, 12, 4, 3, 10, 101, 3423 };
            double[] preturi = new double[] { 13, 5, 1.5, 39, 100 };

            Console.WriteLine(numere.Length);
            Console.WriteLine(numere.Rank);

            Console.WriteLine("Numerele castigatoare sunt: -------------------------------------");

            for (int index = 0; index < numere.Length; index++)
            {
                Console.WriteLine(numere[index]);
            }

            for (int i = 0; i < preturi.Length; i++)
            {
                preturi[i] *= 0.9;
            }

            Console.WriteLine("Preturile reduse sunt:");

            for (int i = 0; i < preturi.Length; i++)
            {
                Console.WriteLine(preturi[i]);
            }

            string[,] tabla = new string[3, 3] {
                { "0", "0", "X" },
                { "X", "0", "X" },
                { "0", "X", "0" } };

            if (tabla[0, 0] == tabla[1, 1] && tabla[1, 1] == tabla[2, 2])
            {
                Console.WriteLine("Castigatorul este: " + tabla[0, 0]);
            }

            for (int r = 0; r < tabla.GetLength(0); r++)
            {
                string row = "";
                for (int c = 0; c < tabla.GetLength(1); c++)
                {
                    row += " " + tabla[r, c];
                }
                Console.WriteLine(row);
            }

            //Sortare, cautare, comparare
            string[] names = new string[] { "Alex", "Ionut", "Dorin", "Bianca" };

            Console.WriteLine("Inainte de sortare:");

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Array.Sort(names);

            Console.WriteLine("Dupa sortare:");

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            int[] Numbers = new int[] { 12, 3, 5, 7, 9 };
            int[] Numbers2 = new int[] { 1, 3, 5, 7, 9 };

            int five = Array.Find(Numbers, number => number == 5);
            int greaterThan7 = Array.Find(Numbers, number => number > 7);

            Console.WriteLine("Find 5:" + five);
            Console.WriteLine("Greater than 7:" + greaterThan7);

            bool areEqual = Numbers.SequenceEqual(Numbers2);
            if (areEqual == true)
            {
                Console.WriteLine("Numbers = Numbers2");
            }
            else
            {
                Console.WriteLine("Numbers NU e egal cu Numbers2");
            }

            double[] temperaturi = new double[10] { 13, 12, 10, 8, 9, 11, 19, 20, 15, 12 };

            double[] first2 = temperaturi.Take<double>(2).ToArray();

            Console.WriteLine("Prognoza urmatoarele 2 zile:");
            for (int i = 0; i < first2.Length; i++)
            {
                Console.WriteLine(first2[i]);
            }

            Console.WriteLine("Temperatura medie urmatoarele 10 zile: " + temperaturi.Average());

            Console.WriteLine("Temperatura MAXIMA:" + temperaturi.Max());
            Console.WriteLine("Temperatura MINIMA:" + temperaturi.Min());

            if (temperaturi.Contains(20))
            {
                Console.WriteLine("Va fi o zi calda in urmatoarele 10 zile");
            }

            if (temperaturi.Any(x => x > 20))
            {
                Console.WriteLine("Exista minimum o zi foarte calda");
            }

            if (temperaturi.All(x => x >= 8))
            {
                Console.WriteLine("Toate zilele vor avea cel putin 8 grade");
            }

            Console.WriteLine("Suma gradelor pe urmatoarele 10 zile:" + temperaturi.Sum());

            double[] peste10 = temperaturi.Where(x => x > 10).ToArray();

            Console.WriteLine("Temperaturi peste 10:");
            for (int i = 0; i < peste10.Length; i++)
            {
                Console.WriteLine(peste10[i]);
            }

            int ct = temperaturi.Count(x => x > 10);
            Console.WriteLine(ct + " din urmatoarele 10 zile au temperaturi peste 10");

            Console.ReadKey();
        }

    }
}
