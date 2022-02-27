using System;
using System.Collections.Generic;
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
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            program.RunLists();
        }
    }
}

