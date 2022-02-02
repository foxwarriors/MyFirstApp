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
            string txt = "ABCDEF";
            Console.WriteLine("The length of the txt string is: " + txt.Length);

            Console.WriteLine("A doua litera din mesaj este: " + txt[1]);

            string b = "buna ziua";

            txt += " hello";

            txt += b;

            int year = 2021;
            string curs = "C#";
            string lectie = "Lectia3";

            string mesaj = $"Buna, bine ai venit la cursul de {curs} din {year}, te afli la: {lectie}";

            Console.WriteLine(txt);

            Console.WriteLine(mesaj);

            Console.WriteLine(mesaj.ToUpper());
            Console.WriteLine(mesaj.ToLower());

            string untrimmed = "___Hello World___";
            Console.WriteLine(untrimmed + ">TrimStart>" + untrimmed.TrimStart('_'));
            Console.WriteLine(untrimmed + ">TrimEnd>" + untrimmed.TrimEnd('_'));
            Console.WriteLine(untrimmed + ">Trim>" + untrimmed.Trim('_'));

            string a = "Buna ziua";
            Console.WriteLine(a + " starts with B: " + a.StartsWith("B"));
            Console.WriteLine(a + " starts with Z: " + a.StartsWith("Z"));
            Console.WriteLine(a + " starts with Bu: " + a.StartsWith("Bu"));

            Console.WriteLine(a + " ends with a: " + a.EndsWith("a"));
            Console.WriteLine(a + " ends with ua: " + a.EndsWith("ua"));
            Console.WriteLine(a + " ends with u: " + a.EndsWith("u"));

            a = "Ana are mere, Ionut are pere";
            Console.WriteLine("Aparitia primului 'are': " + a.IndexOf("are"));

            Console.WriteLine("Aparitia ULTIMULUI 'are': " + a.LastIndexOf("are"));

            a = "Ana e la mare si are cu ea niste mere";
            Console.WriteLine("Aparitia primului 'are':" + a.IndexOf("are"));

            string s = "Visual C# Course";
            Console.WriteLine(s + " substring (7, 2): " + s.Substring(7, 2));

            s = "Bun venit la curs";
            string[] cuvinte = s.Split(' ');
            for (int i = 0; i < cuvinte.Length; i++)
            {
                Console.WriteLine($"Cuvant: { cuvinte[i]}");
            }

            int[] numereCastigatoare = new int[] { 1, 7, 8, 11, 32, 44 };
            string toate = string.Join("-", numereCastigatoare);
            Console.WriteLine("Castigatoare: " + toate);

            string str = "Meniul zilei";
            Console.WriteLine(str + ">PadLeft 15: " + str.PadLeft(15));
            Console.WriteLine(str + ">PadRight 15: " + str.PadRight(15));

            Console.WriteLine(str + ">PadLeft 15 *: " + str.PadLeft(15, '*'));
            Console.WriteLine(str + ">PadRight 15 *: " + str.PadRight(15, '*'));

            string A = "alex";
            string B = "Alex";
            if (string.Compare(A, B, StringComparison.OrdinalIgnoreCase) < 0)
            {
                Console.Write($"1. {A} 2. {B}");
            }

            else if (string.Compare(A, B, StringComparison.OrdinalIgnoreCase) > 0)
            {
                Console.Write($"1. {B} 2. {A}");
            }
            else
            {
                Console.WriteLine("A si B sunt egale");
            }

            mesaj = "Aici suntem la curs";
            Console.WriteLine(mesaj + ">Remove9:" + mesaj.Remove(9));

            string mesajPartial = mesaj.Remove(0, 4);
            Console.WriteLine(mesaj + ">Remove(0,4):" + mesajPartial);

            s = "Afara sunt 4 grade";
            Console.WriteLine(s + ">Replaced 4 with 20:" + s.Replace("4", "20"));

            string listaCumparaturi = "lapte, mere, paine, rosii";
            bool mere = listaCumparaturi.Contains("mere");
            if (mere)
            {
                Console.WriteLine("Avem mere pe lista");
            }
            else
            {
                Console.WriteLine("Nu avem mere pe lista");
            }


        }

    }
}
