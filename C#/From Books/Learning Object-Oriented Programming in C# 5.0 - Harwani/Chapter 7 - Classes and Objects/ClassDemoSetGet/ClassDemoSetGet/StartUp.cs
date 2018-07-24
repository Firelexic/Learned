using System;

namespace ClassDemoSetGet
{
    public class StartUp
    {
        public static void Main()
        {
            Worker w = new Worker();
            w.Code = 101;
            w.Name = "Kelly";
            w.BasicSalary = 5000;
            w.ShowWorker();
        }
    }
}
