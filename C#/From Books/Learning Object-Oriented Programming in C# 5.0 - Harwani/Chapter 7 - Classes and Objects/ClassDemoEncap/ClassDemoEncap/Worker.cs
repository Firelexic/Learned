using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoEncap
{
    public class Worker
    {
        private int code, basicSalary;
        private string name;

        public void SetWorker(int x, string y, int z)
        {
            code = x;
            name = y;
            basicSalary = z;
        }
        public void showWorker()
        {
            Console.WriteLine("Code : {0}, Name : {1}, Salary : {2}",code,name,basicSalary);
        }
    }
}
