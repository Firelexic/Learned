using System;

namespace ClassDemoWorkCon
{
    public class StartUp
    {
        public static void Main()
        {
            Worker workOne = new Worker(101, "Kelly", 5000);
            Worker workTwo = new Worker(102, "David", 6500);
            workOne.ComputeSal();
            workTwo.ComputeSal();
            Console.WriteLine("Information of first worker Kelly is as under : ");
            workOne.showWorker();
            Console.WriteLine("Information of second worker David is as under : ");
            workTwo.showWorker();
        }
    }
}
