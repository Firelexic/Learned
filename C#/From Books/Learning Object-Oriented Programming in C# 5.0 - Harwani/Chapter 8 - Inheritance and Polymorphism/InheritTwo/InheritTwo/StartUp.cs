using System;

namespace InheritTwo
{
    public class StartUp
    {
        public static void Main()
        {
            Worker workOne = new Worker();
            Officer officeOne = new Officer();
            workOne.setWorker(101, "Kelly", 5000);
            officeOne.setWorker(102, "David", 7000);
            officeOne.SetOfficer(400, 200);
            Console.WriteLine("Information of worker is as given below : ");
            workOne.showWorker();
            Console.WriteLine("Information of officer is as given below : ");
            officeOne.showWorker();
            officeOne.ShowOfficer();
        }
    }
}
