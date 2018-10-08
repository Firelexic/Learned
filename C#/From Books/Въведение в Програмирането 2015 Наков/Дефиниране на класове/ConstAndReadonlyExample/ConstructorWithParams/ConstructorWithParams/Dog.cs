using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorWithParams
{
    public class Dog
    {
        public string name;
        public int age;
        public double lenth;

        public Dog(string dogName,int dogAge,double dogLength)
        {
            this.name = dogName;
            this.age = dogAge;
            this.lenth = dogLength;
           
        }
    }
}
