using System;
using System.IO;
using System.Text;

namespace Lectia_9_ExempluStreamBytes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lectia9 Snippet1
            //scriere cu stream de bytes

            string path = @"/Users/adrianciuca/Desktop/Hello.txt";

            using(FileStream stream = new FileStream(path,FileMode.Open,FileAccess.Write))
            {
                string mesaj = "salut, din c# in fisier!";
                byte[] data = Encoding.UTF8.GetBytes(mesaj);
                stream.Write(Encoding.UTF8.GetBytes(mesaj), 0, Encoding.UTF8.GetBytes(mesaj).Length);
               //stream.Write(data, 0, data.Length);
            }

            Console.WriteLine("Am terminat scrierea in fisierul: " + path);


            //scriere cu string de caractere

           /* using(StreamWriter sw = new StreamWriter(path))
            {
                string characters = "Direct acest mesaj. Voi ce faceti?";
                sw.Write(characters);
            }*/

            #endregion
        }
    }
}
