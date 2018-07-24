using System;
using System.Collections.Generic;
using System.Text;

namespace InheritTwo
{
    public class Officer : Worker
    {
        private float houseAllowance, childAllowance;
        public void SetOfficer(float u,float v)
        {
            houseAllowance = u;
            childAllowance = v;
        }

        public void ShowOfficer()
        {
            Console.WriteLine("Household allowance : {0},Child allowance : {1}",houseAllowance,childAllowance);
        }
    }
}
