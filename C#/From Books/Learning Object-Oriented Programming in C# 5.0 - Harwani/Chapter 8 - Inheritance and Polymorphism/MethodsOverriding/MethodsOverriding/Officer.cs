using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsOverriding
{
    public class Officer : Worker
    {
        private float houseAllowance;
        public void SetOfficer(int x,string y,int z)
        {
            SetWorker(x, y, z);
        }

        public override void householdAllowance()
        {
            houseAllowance = (float)basicSalary * 8 / 100;
            Console.WriteLine("Household allowance: {0}", houseAllowance);
        }

        public void showOfficer()
        {
            ShowWorker();
        }
    }
}
