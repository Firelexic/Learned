using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyExample
{
    public class Dog
    {
        private int age;

        public Dog(int age)
        {
            this.age = age;
        }

        public Dog() { }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid argument: Age should be a positive number.");
                }
                this.age = value;
            }
        }
        
    }
}
