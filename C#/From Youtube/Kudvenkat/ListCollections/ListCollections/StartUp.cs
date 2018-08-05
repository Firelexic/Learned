using System;
using System.Collections.Generic;

namespace ListCollections
{
    public class StartUp
    {
        public static void Main()
        {
            Customer customerOne = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            Customer customerTwo = new Customer()
            {
                ID = 110,
                Name = "Pam",
                Salary = 6500
            };

            Customer customerThree = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 3500
            };

            Customer[] customers = new Customer[2];
            customers[0] = customerOne;
            customers[1] = customerTwo;

            List<Customer> customerList = new List<Customer>(2);
            customerList.Add(customerOne);
            customerList.Add(customerTwo);
            customerList.Add(customerThree);

            for (int i = 0; i < customerList.Count; i++)
            {
                Customer cus = customerList[i];
                Console.WriteLine("ID = {0},Name = {1},Salary = {2}",cus.ID,cus.Name,cus.Salary);

            }
        }
    }
}
