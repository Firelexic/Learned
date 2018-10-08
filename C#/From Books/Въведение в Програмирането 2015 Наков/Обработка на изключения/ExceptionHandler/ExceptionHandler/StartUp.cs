using System;
using System.IO;

namespace ExceptionHandler
{
    public class StartUp
    {
        public static void ReadFile(string filename)
        {
            //Exceptions could be thrown in the code below
            try
            {
                TextReader reader = new StreamReader(filename);
                string line = reader.ReadLine();
                Console.WriteLine(line);
                reader.Close();
            }
            catch (FileNotFoundException fnfe)
            {
                //Exception handler forFileNotFoundException
                //We just inform the user that there is no such file
                Console.WriteLine("The file '{0}' is not found.", filename);
                
            }
            catch(IOException ioe)
            {
                //Exception handler for other input/output exceptions
                //We just print the stack trace on the console
                Console.WriteLine(ioe.StackTrace);
            }
        }
    

        public static void Main()
        {
            ReadFile("WrongTextFile.txt");
        }
    }
}
