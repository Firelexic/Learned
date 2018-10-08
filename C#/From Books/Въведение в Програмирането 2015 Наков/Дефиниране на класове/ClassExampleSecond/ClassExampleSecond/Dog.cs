using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExampleSecond
{
    public class Dog
    {
        private string name;
        private int age;
        private int length;
        private bool isMale;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public bool IsMale
        {
            get { return isMale; }
            set { isMale = value; }
        }
    }
}
