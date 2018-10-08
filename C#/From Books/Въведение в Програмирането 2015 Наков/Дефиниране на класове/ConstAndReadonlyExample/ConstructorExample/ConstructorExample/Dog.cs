using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorExample
{
    public class Dog
    {
        private string name;
        private int age;
        private double length;
        private Collar collar;

        public Dog()
        {
            this.name = "Sharo";
            this.age = 3;
            this.length = 0.5;
            this.collar = new Collar();
        }
    }
}
