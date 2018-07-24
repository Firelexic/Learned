using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoWorkCon
{
    public class Worker
    {
        private int code;
        private int basicSalary;
        private float houseAllowance;
        private float childAllowance;
        private float grossSalary;
        private string name;

        public Worker(int code,string name,int basicSalary)
        {
            this.code = code;
            this.name = name;
            this.basicSalary = basicSalary;
        }

        public void ComputeSal()
        {
            houseAllowance = (float)basicSalary * 6 / 100;
            childAllowance = 250;
            grossSalary = basicSalary + houseAllowance + childAllowance;
        }

        public void showWorker()
        {
            Console.WriteLine("Code: {0}, Name {1}, BasicSalary : {2}",code,name,basicSalary);
            Console.WriteLine("Household allowance: {0},Child allowance : {1}," +
                "Gross Salary : {2}",houseAllowance,childAllowance,grossSalary);
        }
    }
}
