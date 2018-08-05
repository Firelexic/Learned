using System;
using System.IO;

namespace ExceptionHandling
{
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                StreamReader streamReader = new StreamReader(@"E:\Goods.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                streamReader.Close();
            }
            catch (FileNotFoundException exeption)
            {

                Console.WriteLine(exeption.Message);
                Console.WriteLine();
                Console.WriteLine(exeption.StackTrace);
            }
            

        }
    }
}
