using System;
using System.Collections.Generic;
using System.Text;

namespace InheritTwo
{
    public class Worker
    {
        private int code;
        private int basicSalary;
        private string name;
        
        public void setWorker(int x,string y,int z)
        {
            code = x;
            name = y;
            basicSalary = z;
        }

        public void showWorker()
        {
            Console.WriteLine("Code: {0}, Name {1}, Salary : {2}",code,name,basicSalary);
        }
    }
}
