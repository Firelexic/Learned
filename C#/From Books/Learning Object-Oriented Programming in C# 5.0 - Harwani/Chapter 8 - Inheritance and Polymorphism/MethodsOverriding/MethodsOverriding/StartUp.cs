using System;

namespace MethodsOverriding
{
    public class StartUp
    {
        public static void Main()
        {
            Worker wkr = new Worker();
            Officer ofcr = new Officer();
            wkr.SetWorker(101, "Kelly", 5000);
            ofcr.SetOfficer(102, "David", 7000);
            Console.WriteLine("Information of worker is as given below : ");
            wkr.ShowWorker();
            wkr.householdAllowance();
            Console.WriteLine("Information of officer is as given below : ");
            ofcr.ShowWorker();
            ofcr.householdAllowance();
        }
    }
}
