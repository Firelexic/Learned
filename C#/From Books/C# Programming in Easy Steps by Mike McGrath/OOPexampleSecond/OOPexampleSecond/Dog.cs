using System;
using System.Collections.Generic;
using System.Text;

namespace OOPexampleSecond
{
    class Dog
    {
        private string name;
        private string color;
        private int age;

        public void SetValue(string name,int age,string color)
        {
            this.name = name;
            this.age = age;
            this.color = color;
        }
        public string GetName() { return name; }
        public int GetAge() { return age; }
        public string GetColor() { return color; }

        public string Bark() { return "Woof,woof"; }
    }

    

}
