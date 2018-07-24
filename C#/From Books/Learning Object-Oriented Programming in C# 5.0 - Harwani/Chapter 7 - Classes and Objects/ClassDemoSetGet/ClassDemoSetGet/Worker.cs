using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoSetGet
{
    public class Worker
    {
        private int code;
        private int basicSalary;
        private string name;

        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public int BasicSalary
        {
            get { return basicSalary; }
            set { basicSalary = value; }
        }

        public void ShowWorker()
        {
            Console.WriteLine("Code: {0}, Name {1}, BasicSalary : {2}",Code,Name,BasicSalary);
        }
    }
}
