using System;

namespace ReadingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // Read each line in the text line by line and store the lines in an array
            string [] lines = System.IO.File.ReadAllLines(@"/Users/owner-name/Desktop/paper.txt");

            System.Console.WriteLine("This text file read = ");
            // Display the contents of the file and seperate paragraphs with a tab
            foreach(string line in lines) {
                Console.WriteLine("\t" + line);
            }
            Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
        }
    }
}
