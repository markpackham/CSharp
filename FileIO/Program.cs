using System;

// Used for file and directory
// manipulation
using System.IO;
using System.Text;

// Start VS with admin rights by
// right clicking it and run as 
// administrator

namespace FileIO
{

    class Program
    {

        static void Main(string[] args)
        {
            // ----- MESSING WITH DIRECTORIES -----

            // Get access to the current directory
            DirectoryInfo currDir = new DirectoryInfo(".");

            // Get access to a directory with a path
            DirectoryInfo markDir = new DirectoryInfo(@"E:\xampp\htdocs\CSharp\FileIO\FileIOExamples");

            // Get the directory path
            Console.WriteLine("Directory FullName: "+markDir.FullName);

            // Get the directory name
            Console.WriteLine("Name: "+markDir.Name);

            // Get the parent directory
            Console.WriteLine("Parent Directory: "+markDir.Parent);

            // What type is it
            Console.WriteLine("Attributes: "+markDir.Attributes);

            // When was it created
            Console.WriteLine("Creation Time: "+markDir.CreationTime);

            // Create a directory
            DirectoryInfo dataDir = new DirectoryInfo(@"E:\xampp\htdocs\CSharp\FileIO\FileIOExamples");
            dataDir.Create();

            // Delete a directory
            // Directory.Delete(@"E:\xampp\htdocs\CSharp\FileIO\FileIOExamples");

            // ----- SIMPLE FILE READING & WRITING -----

            // Write a string array to a text file
            string[] customers =
            {
                "Bob Smith",
                "Sally Smith",
                "Robert Smith"
            };

            string textFilePath = @"E:\xampp\htdocs\CSharp\FileIO\FileIOExamples\testfile1.txt";
            ;
            // Write the array
            File.WriteAllLines(textFilePath,
                customers);

            // Read strings from array
            foreach (string cust in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine($"Customer : {cust}");
            }

            // ----- GETTING FILE DATA -----

            DirectoryInfo myDataDir = new DirectoryInfo(@"E:\xampp\htdocs\CSharp\FileIO\FileIOExamples");

            // Get all txt files 
            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt",
                SearchOption.AllDirectories);

            // Number of matches
            Console.WriteLine("Matches : {0}",
                txtFiles.Length);

            foreach (FileInfo file in txtFiles)
            {
                // Get file name
                Console.WriteLine("File name: "+file.Name);

                // Get bytes in file
                Console.WriteLine("File length in bytes: "+file.Length);
            }

            // ----- FILESTREAMS -----
            // FileStream is used to read and write a byte
            // or an array of bytes. 

            string textFilePath2 = @"E:\xampp\htdocs\CSharp\FileIO\FileIOExamples\testfile2.txt";

            // Create and open a file
            FileStream fs = File.Open(textFilePath2,
                FileMode.Create);

            string randString = "This is a random string";

            // Convert to a byte array
            byte[] rsByteArray = Encoding.Default.GetBytes(randString);

            // Write to file by defining the byte array,
            // the index to start writing from and length
            fs.Write(rsByteArray, 0,
                rsByteArray.Length);

            // Move back to the beginning of the file
            fs.Position = 0;

            // Create byte array to hold file data
            byte[] fileByteArray = new byte[rsByteArray.Length];

            // Put bytes in array
            for (int i = 0; i < rsByteArray.Length; i++)
            {
                fileByteArray[i] = (byte)fs.ReadByte();
            }

            // Convert from bytes to string and output
            Console.WriteLine(Encoding.Default.GetString(fileByteArray));

            // Close the FileStream
            fs.Close();

            // ----- STREAMWRITER / STREAMREADER -----
            // These are best for reading and writing strings

            string textFilePath3 = @"E:\xampp\htdocs\CSharp\FileIO\FileIOExamples\testfile3.txt";

            // Create a text file
            StreamWriter sw = File.CreateText(textFilePath3);

            // Write to a file without a newline
            sw.Write("This is a random ");

            // Write to a file with a newline
            sw.WriteLine("sentence.");

            // Write another
            sw.WriteLine("This is another sentence.");

            // Close the StreamWriter
            sw.Close();

            // Open the file for reading
            StreamReader sr = File.OpenText(textFilePath3);

            // Peek returns the next character as a unicode
            // number. Use Convert to change to a character
            Console.WriteLine("Peek returns the next character as a unicode number : {0}",
                Convert.ToChar(sr.Peek()));

            // Read to a newline
            Console.WriteLine("1st String : {0}",
                sr.ReadLine());

            // Read to the end of the file starting
            // where you left off reading
            Console.WriteLine("Everything : {0}",
                sr.ReadToEnd());

            sr.Close();

            // ----- BINARYWRITER / BINARYREADER -----
            // Used to read and write data types 
            string textFilePath4 = @"E:\xampp\htdocs\CSharp\FileIO\FileIOExamples\testfile4.dat";

            // Get the file
            FileInfo datFile = new FileInfo(textFilePath4);

            // Open the file
            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

            // Data to save to the file
            string randText = "Random Text";
            int myAge = 42;
            double height = 6.25;

            // Write data to a file
            bw.Write(randText);
            bw.Write(myAge);
            bw.Write(height);

            bw.Close();

            // Open file for reading
            BinaryReader br = new BinaryReader(datFile.OpenRead());

            // Output data
            Console.WriteLine("ReadString: " + br.ReadString());
            Console.WriteLine("ReadInt32: " + br.ReadInt32());
            Console.WriteLine("ReadDouble: "+ br.ReadDouble());

            br.Close();

            Console.ReadLine();

        }
    }
}