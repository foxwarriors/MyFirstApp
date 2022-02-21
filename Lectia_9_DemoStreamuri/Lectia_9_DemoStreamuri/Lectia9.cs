using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Newtonsoft.Json;

namespace Lectia_9_DemoStreamuri
{
    public class Lectia9
    {
            public void ReadFromFile(string path)
            {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {


                byte[] read = new byte[fs.Length];

                fs.Read(read, 0, (int)fs.Length);

                string mesajCitit = Encoding.UTF8.GetString(read);
                Console.WriteLine("Am gasit in fisier mesajul: ");
                Console.WriteLine(mesajCitit);
            }
            }

        public void WriteToFile(string path)
        {
            
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write))
            { 
            string mesaj = "salut, este " + DateTime.Now.ToString();
            byte[] bytes = Encoding.UTF8.GetBytes(mesaj);

            fs.Write(bytes, 0, bytes.Length);

            }            
        }

        public void TestFileClass(string path)
        {
            if(!File.Exists(path))
                using (FileStream stream = File.Create(path))
                {
                    string mesaj = "mesaj nou";
                    byte[] bytes = Encoding.UTF8.GetBytes(mesaj);

                    stream.Write(bytes, 0, bytes.Length);

                }
        }

        public void WriteCharacters(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                string characters = "Voi ce faceti?";

                Console.WriteLine(sw.Encoding);

                sw.WriteLine(characters);
            }
        }


        public void Buffers(string path,int size)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] bytes = Encoding.UTF8.GetBytes("12345");
                for(int i = 0; i < 1000000; i++)
                {
                    fs.Write(bytes, 0, bytes.Length);
                }
            }
        
            using (FileStream fr = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (BufferedStream bufstream = new BufferedStream(fr, size))
            {
                byte[] chunk = new byte[size];
                int numBytesToRead = (int)fr.Length;

                while(numBytesToRead > 0)
                {
                    chunk = new byte[size];
                    int numBytesRead = bufstream.Read(chunk, 0, chunk.Length);
                    if(numBytesRead == 0)
                        break;

                    numBytesToRead -= numBytesRead;
                    
                }
            }
        }

        public void Play()
        {
            JocXsi0 joc = JocXsi0.Load(@"/Users/adrianciuca/Desktop/Scriere.txt");
            joc.showBoard();
            joc.c8 = "X";
            joc.showBoard();
            joc.Save(@"/Users/adrianciuca/Desktop/X_0.txt");

            JocXsi0 joc2 = JocXsi0.Load(@"/Users/adrianciuca/Desktop/Scriere.txt");

            string rezultat = JsonConvert.SerializeObject(joc2);
            Console.WriteLine(rezultat);

            using (StreamWriter sw = new StreamWriter(@"/Users/adrianciuca/Desktop/json1.json"))
            {
                sw.Write(rezultat);
            }

            JocXsi0 loaded = JsonConvert.DeserializeObject<JocXsi0>(rezultat);
            Console.WriteLine("Deserializat JSON: ");
            loaded.showBoard();

            IFormatter formatter = new BinaryFormatter();

            JocXsi0 joc3 = new JocXsi0();
            joc3 = JocXsi0.Load(@"/Users/adrianciuca/Desktop/x12.txt");

            using (FileStream stream = new FileStream(@"/Users/adrianciuca/Desktop/tabla1.bin", FileMode.OpenOrCreate,FileAccess.Write))
            {
                formatter.Serialize(stream, joc3); // ?   ? ? ?? ? ? ? ? ? ? ? ? ? ? ? de ce 
            }
        }

        public class JocXsi0
        {
            public string c1;
            public string c2;
            public string c3;
            public string c4;
            public string c5;
            public string c6;
            public string c7;
            public string c8;
            public string c9;

            public JocXsi0() { }

            public void Save(string path)
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    string board = c1 + "|" + c2 + "|" + c3 + "|" + c4 + "|" + c5 + "|" + c6 + "|" + c7 + "|" + c8 + "|" + c9;
                    byte[] boardBytes = Encoding.UTF8.GetBytes(board);
                }
            }

            public static JocXsi0 Load(string path)
            {
                JocXsi0 joc = new JocXsi0();

                using(FileStream fs = new FileStream(path, FileMode.Open,FileAccess.Read))
                {
                    byte[] fileContent = new byte[fs.Length];
                    fs.Read(fileContent, 0, fileContent.Length);

                    string board = Encoding.UTF8.GetString(fileContent);
                    string[] cells = board.Split('|');
                    joc.c1 = cells[0];
                    joc.c2 = cells[1];
                    joc.c3 = cells[2];
                    joc.c4 = cells[3];
                    joc.c5 = cells[4];
                    joc.c6 = cells[5];
                    joc.c7 = cells[6];
                    joc.c8 = cells[7];
                    joc.c9 = cells[8];

                }
                return joc;
            }
            public void showBoard()
            {
                string line1 = c1 + "|" + c2 + "|" + c3;
                string line2 = c4 + "|" + c5 + "|" + c6;
                string line3 = c7 + "|" + c8 + "|" + c9;

                Console.WriteLine(line1);
                Console.WriteLine(line2);
                Console.WriteLine(line3);

            }
        }
    }
}
