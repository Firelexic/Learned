using System;
using System.Collections.Generic;
using System.Text;

namespace IntroductionToClass
{
    public class Customer
    {
        string firstName;
        string lastName;

        public Customer() : 
            this("No First Name","No Last Name")
        {

        }
        

        public Customer(string firstNames,string lastNames)
        {
            this.firstName = firstNames;
            this.lastName = lastNames;
        }

        public void PrintFullName()
        {
            Console.WriteLine("Full Name = {0} {1}",this.firstName,this.lastName);
        }

         
    }
}
