using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace andestech.learning2022.krasn
{
    internal class IOTest
    {

        static public void Main(string[] args)
        {
            //  DelegateTest.Main2(args);
            //  EventTest.Main2(args);
            ReflectionTest.Main2(args);

            File.WriteAllText("file1.txt",
                "Hello!\nПривет!\nЗдравствуй!\nSalute!\n",
                Encoding.UTF8);

            File.Copy("file1.txt", $"file1_{DateTime.Now:yyyy.MM.dd_HH.mm.ss.fff}.txt");

            // FileInfo / Directory / DirectoryInfo 

            string[] lines =
                File.ReadAllLines("file1.txt", Encoding.UTF8);
            foreach(var line in lines) WriteLine(line);

            using (FileStream fs = new FileStream("file2.txt", FileMode.Append))
            {
                string data = $"Data: {DateTime.Now:yyyy.MM.dd HH:mm:ss.fff}\n";
                byte[] bytes = Encoding.UTF8.GetBytes(data);
                fs.Write(bytes, 0, bytes.Length);
            }
            WriteLine("--------------------");

            using (FileStream fs = new FileStream("file2.txt", FileMode.Open))
            {

                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, bytes.Length);

                string data = Encoding.UTF8.GetString(bytes);
                WriteLine(data);
            }

            using (BinaryWriter bw =
                new BinaryWriter(
                new FileStream("file3.bin", FileMode.OpenOrCreate)))
            {
                bw.Write(19284798749827L);
                bw.Write((byte)111);
            }


        }
    }
}
