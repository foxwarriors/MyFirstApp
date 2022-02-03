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

            afisareVector(numere);

            for (int i = 0; i < preturi.Length; i++)
            {
                preturi[i] *= 0.9;
            }

            Console.WriteLine("Preturile reduse sunt:");

            afisareVector(preturi);

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

            afisareVector(names);

            Array.Sort(names);

            Console.WriteLine("Dupa sortare:");

            afisareVector(names);

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
            afisareVector(first2);

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

            afisareVector(peste10);

            int ct = temperaturi.Count(x => x > 10);
            Console.WriteLine(ct + " din urmatoarele 10 zile au temperaturi peste 10");

            Console.WriteLine(Adunare(10, 11));

            Console.WriteLine(repeatString("ana are mere ", 2));

            string s = "Ana are mere ";
            string mesaj = repeatString(s, 3);

            Console.WriteLine(mesaj);

            CheckInGuest("Viorel", 7, true);

            CheckInGuest(nrN: 5, name: "Giani");

            Console.WriteLine(ariaCerc(2.3));

            int x = 5, y = 6;

            inversare(ref x,ref y);

            Console.WriteLine(x + " " + y);

            int[] vector = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            afisareVectorPare(vector);
            afisareVectorImpare(vector);

            Console.ReadKey();
        }



        static void afisareVector(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
                Console.WriteLine(vector[i]);
        }

        static void afisareVector(double[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
                Console.WriteLine(vector[i]);
        }

        static void afisareVector(string[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
                Console.WriteLine(vector[i]);
        }

        static int Adunare(int a, int b)
        {
            return a + b;
        }

        static string repeatString(string mesaj,int nr = 2)
        {
            string result = "";

            for (int i = 0; i < nr; i++)
                result += mesaj;

            return result;
        }

        static void CheckInGuest(string name, int nrN, bool wantsBr = false)
        {
            Console.WriteLine($"Am cazat pe {name} pentru {nrN} nopti, mic dejun: {wantsBr}");
        }

        static double ariaCerc(double raza)
        {
            double pi = 3.14;
            return pi * raza * raza;
        }

        static void inversare(ref int x,ref int y)
        {
            int z = x;
            x = y;
            y = z;
        }

        static void afisareVectorPare(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] % 2 == 0)
                 Console.WriteLine(vector[i]); 
            }
        }
        static void afisareVectorImpare(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] % 2 == 1)
                    Console.WriteLine(vector[i]);
            }
        }
    }
}
