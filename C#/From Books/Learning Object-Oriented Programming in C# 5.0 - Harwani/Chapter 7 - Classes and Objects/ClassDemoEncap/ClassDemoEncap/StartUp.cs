using System;

namespace ClassDemoEncap
{
    public class StartUp
    {
        public static void Main()
        {
            Worker firstWorker = new Worker();
            firstWorker.setWorker(101, "Kelly", 5000);
            firstWorker.showWorker();
        }
    }
}
