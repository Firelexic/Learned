using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsOverriding
{
    public class Worker
    {
        protected int code;
        protected int basicSalary;
        protected string name;
        private float houseAllowance;

        public void SetWorker(int x,string y,int z)
        {
            code = x;
            name = y;
            basicSalary = z;
        }

        public virtual void householdAllowance()
        {
            houseAllowance = (float)basicSalary * 6 / 100;
            Console.WriteLine("Household allowance : {0}", houseAllowance);
        }

        public void ShowWorker()
        {
            Console.WriteLine("Code : {0}, Name : {1}, Salary : {2}",code,name,basicSalary);
        }
    }
}
