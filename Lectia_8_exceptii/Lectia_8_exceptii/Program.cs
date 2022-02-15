using System;
using System.IO;
using System.Linq;

namespace Lectia_8_exceptii
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string text = File.ReadAllText(@"/Users/adrianciuca/Desktop/Hello.txt");
                int x = 5 - 4;
                int y = 45 / x;
                int z = 12;
                Console.WriteLine(z);
                int[] arr = new int[] { 3, 2, 5, 6, 1 };
                Console.WriteLine(arr[2]);
                Console.WriteLine(CalculateAge(1992));
                try
                {
                    FacultyStudent st = new FacultyStudent();
                    st.An = 1;
                    st.Note = new decimal[12] { 5, 2, 6, 3, 6, 5, 5, 5, 2, 5, 4, 2 };
                    st.PromovareAn();
                    Console.WriteLine("Studentul este in anul " + st.An);
                }
                catch (CannotPromoteException ce)
                {
                    string detailMessage = "";
                    Console.WriteLine(ce.Message);
                    for (int i = 0; i < ce.NoteSub5.Length; i++)
                    {
                        detailMessage += ce.NoteSub5[i] + " ";
                    }
                    Console.WriteLine(detailMessage);
                }
                string path = @"/Users/adrianciuca/Desktop/Hello.txt";
                StreamReader file = new StreamReader(path);
                string line = "";
                try
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        int number = int.Parse(line);
                        Console.WriteLine(number);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error reading number from file !");
                }
                finally
                {
                    if (file != null)
                    {
                        file.Close();
                    }
                }
            }
            catch (IOException fileException)
            {
                Console.WriteLine("Nu am gasit fisierul cautat");
            }

            catch (ArithmeticException ex)
            {
                Console.WriteLine("Ai incercat impartirea la 0");
            }
            catch (IndexOutOfRangeException indexException)
            {
                Console.WriteLine("Index nepermis");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("A aparut o problema");
            }

        }

        public static int CalculateAge(int birthYear)
        {
            if (birthYear < 0)
            {
                throw new ArgumentException("Anul nasterii nu poate fi negativ");
            }
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;
            return age;
        }
    }

}

public class FacultyStudent
{
    public int An;
    public decimal[] Note = new decimal[12];

    public void PromovareAn()
    {
        if (Note.Count(n => n < 5) >= 4)
        {
            decimal[] NoteSub5 = Note.Where(g => g < 5).ToArray();
            throw new CannotPromoteException(NoteSub5, "Prea multe restante");
        }
        An++;
    }

}

public class CannotPromoteException : Exception
{
    public decimal[] NoteSub5;
    public CannotPromoteException(decimal[] sub5, string message) : base(message)
    {
        NoteSub5 = sub5;
    }

}