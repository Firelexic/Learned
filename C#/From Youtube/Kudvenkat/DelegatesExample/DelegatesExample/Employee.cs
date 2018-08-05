using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesExample
{
    public delegate bool IsPromotable(Employee empl);

    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public int experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList,IsPromotable IsEligibleToPromote)
        {
            foreach (Employee employee in employeeList)
            {
                if (IsEligibleToPromote(employee))
                {
                    Console.WriteLine($"{employee.name} = {employee.salary}");
                }
            }
        }
    }
}
