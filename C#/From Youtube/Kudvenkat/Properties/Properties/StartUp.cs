using System;

namespace Properties
{
    public class StartUp
    {
        public static void Main()
        {
            Student firstStudent = new Student();

            firstStudent.Id = 102;
            Console.WriteLine(firstStudent.Id);
        }
    }
}
