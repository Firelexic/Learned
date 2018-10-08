using System;
using System.IO;

namespace StreamWriterExm
{
    public class StartUp
    {
        public static void Main()
        {
            StreamWriter writer = new StreamWriter("Numbers.txt");

            using (writer)
            {
                for (int i = 0; i < 20; i++)
                {
                    writer.WriteLine(i);
                }
                writer.Write("yoo");
            }
            
        }
    }
}
