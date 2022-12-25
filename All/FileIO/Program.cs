using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream Fout = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for (int ic = 1; ic <= 20; ic++)
            {
                Fout.WriteByte((byte)ic);
            }
            Fout.Position = 0;
            for (int index = 0; index <= 20; index++)
            {
                Console.Write(Fout.ReadByte() + " ");
            }
            Fout.Close();
            Console.WriteLine("\nFileClosed");

            FileStream Fin = new FileStream("test.dat", FileMode.Open, FileAccess.Read, FileShare.Read);


            //creating a DirectoryInfo object
            DirectoryInfo mydir = new DirectoryInfo(@"c:\Windows");

            // getting the files in the directory, their names and size
            FileInfo[] f = mydir.GetFiles();
            foreach (FileInfo file in f)
            {
                Console.WriteLine("File Name: {0} Size: {1}", file.Name, file.Length);
            }

            Console.WriteLine("-----------------------------------------------------");

            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("c:/jamaica.txt"))
                {
                    string line_message;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line_message = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line_message);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("-----------------------------------------------------");



            string[] names = new string[] { "Zara Ali", "Nuha Ali" };

            using (StreamWriter sw = new StreamWriter("names.txt"))
            {

                foreach (string str in names)
                {
                    sw.WriteLine(str);
                }
            }

            // Read and show each line from the file.
            string line = "";
            using (StreamReader sr = new StreamReader("names.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine("-----------------------------------------------------");

            BinaryWriter bw;
            BinaryReader br;

            int i = 25;
            double d = 3.14157;
            bool b = true;
            string s = "I am happy";

            //create the file
            try
            {
                bw = new BinaryWriter(new FileStream("mydata", FileMode.Create));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot create file.");
                return;
            }

            //writing into the file
            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return;
            }
            bw.Close();

            //reading from the file
            try
            {
                br = new BinaryReader(new FileStream("mydata", FileMode.Open));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot open file.");
                return;
            }

            try
            {
                i = br.ReadInt32();
                Console.WriteLine("Integer data: {0}", i);
                d = br.ReadDouble();
                Console.WriteLine("Double data: {0}", d);
                b = br.ReadBoolean();
                Console.WriteLine("Boolean data: {0}", b);
                s = br.ReadString();
                Console.WriteLine("String data: {0}", s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read from file.");
                return;
            }
            br.Close();
            Console.ReadKey();
            
        }
    }
}
