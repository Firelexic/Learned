using System;

namespace CallConstFromCon
{
    public class StartUp
    {
        public static void Main()
        {
            Student studOne = new Student(101, "Kelly", 1000);
            Student studTwo = new Student(102, "David", 1000, 2000);
            Student studThree = new Student(103, "Caroline", 1000, 200, 350);
            Console.WriteLine("Information of student kelly is as under : ");
            studOne.showStudent();
            Console.WriteLine("Information of student David is as under : ");
            studTwo.showStudent();
            Console.WriteLine("Information of student Caroline is as under : ");
            studThree.showStudent();
        }
    }
}
