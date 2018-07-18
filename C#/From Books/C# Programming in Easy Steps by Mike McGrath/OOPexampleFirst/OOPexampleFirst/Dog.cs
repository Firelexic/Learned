using System;
using System.Collections.Generic;
using System.Text;

namespace OOPexampleFirst
{
    class Dog
    {
        //member variable
        private string name;
        private int age;
        private string color;

        public void SetName(string tag)
        {
            name = tag;
        }

        public string GetName()
        {
            return name;
        }

        public void SetAge(int yrs)
        {
            age = yrs;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetColor(string coat)
        {
            color = coat;
        }
        public string GetColor()
        {
            return color;
        }

        public string Bark()
        {
            return "Woof,woof";
        }

    }
}
