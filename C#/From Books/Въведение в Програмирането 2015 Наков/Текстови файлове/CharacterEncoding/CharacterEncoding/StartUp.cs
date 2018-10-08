using System;
using System.IO;
using System.Text;

namespace CharacterEncoding
{
    public class StartUp
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader("test.txt", Encoding.GetEncoding("UTF-8"));
            Console.WriteLine(reader.ReadLine());

            reader.Close();
        }
    }
}
