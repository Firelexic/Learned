using System;
using System.IO;

namespace FileReader
{
    public class StartUp
    {
        public static void Main()
        {
            //Create an instance of StreamReader to read from a file
            StreamReader reader = new StreamReader("Sample.txt");

            int lineNumber = 0;

            //Read first line from the text file
            string line = reader.ReadLine();

            //Read the other lines from the text file

            while (line != null)
            {
                lineNumber++;

                Console.WriteLine("Line {0} : {1}",lineNumber,line);

                line = reader.ReadLine();
            }
            reader.Close();
        }
    }
}
