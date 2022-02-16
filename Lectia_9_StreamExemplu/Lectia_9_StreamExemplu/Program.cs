using System;
using System.IO;
using System.Text;

namespace Lectia_9_StreamExemplu
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"/Users/adrianciuca/Desktop/Hello.txt";
            using (FileStream writeStream = new FileStream(path, FileMode.Append))
            {
                string s = "\nHello Friends!";

                byte[] bytes = Encoding.UTF8.GetBytes(s);
                writeStream.Write(bytes, 0, bytes.Length);
            }
            Console.WriteLine("Finish!");

            Console.ReadLine();
        }
    }
}
