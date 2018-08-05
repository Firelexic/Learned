using System;
using System.Collections.Generic;

namespace PropertiesExample
{
    public class Program
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Mixail", 22, 5.20));
            students.Add(new Student("Tsvetan", 22, 5.20));

            Student mixail = students[0];
            Console.WriteLine(mixail.Name);

            foreach (var element in students)
            {
                Console.WriteLine(element.Name);
                Console.WriteLine(element.Age);
                Console.WriteLine(element.Grade);
            }

        }
    }
}
