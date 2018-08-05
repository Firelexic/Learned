using System;
using System.Collections.Generic;

namespace Dictionary
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

            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(customerOne.ID, customerOne);
            dictionaryCustomers.Add(customerTwo.ID, customerTwo);
            dictionaryCustomers.Add(customerThree.ID, customerThree);

            Customer customer119 =  dictionaryCustomers[119];
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",customer119.ID,customer119.Name,customer119.Salary);

            foreach (KeyValuePair<int,Customer> customerKeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("ID = {0}", customerKeyValuePair.Key);
                Customer cust = customerKeyValuePair.Value;
                Console.WriteLine("{ID = {0}, Name {1}, Salary = {2}",cust.ID,cust.Name,cust.Salary);
                Console.WriteLine("--------------------");
            }
        }
    }
}
