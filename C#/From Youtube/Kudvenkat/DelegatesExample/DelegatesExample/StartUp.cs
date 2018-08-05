using System;
using System.Collections.Generic;

namespace DelegatesExample
{


    public class StartUp
    {
        public static void Main()
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee()
            {
                id = 101,
                name = "Mary",
                salary = 5000,
                experience = 5
            });

            empList.Add(new Employee()
            {
                id = 102,
                name = "Mike",
                salary = 4000,
                experience = 4
            });

            empList.Add(new Employee()
            {
                id = 103,
                name = "John",
                salary = 6000,
                experience = 6
            });

            empList.Add(new Employee()
            {
                id = 104,
                name = "Tod",
                salary = 3000,
                experience = 3
            });
            IsPromotable IsPromotable = new IsPromotable(Promote);

            Employee.PromoteEmployee(empList,IsPromotable);

        }
        public static bool Promote(Employee emp)
        {
            if (emp.salary >= 4000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
