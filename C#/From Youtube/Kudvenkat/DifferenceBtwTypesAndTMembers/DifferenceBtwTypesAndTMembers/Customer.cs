﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DifferenceBtwTypesAndTMembers
{
    public class Customer
    {
        private int id;
        private string firstName;
        private string lastName;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string GetFullName()
        {
            return this.firstName + " " + this.lastName;
        }
    }
}
