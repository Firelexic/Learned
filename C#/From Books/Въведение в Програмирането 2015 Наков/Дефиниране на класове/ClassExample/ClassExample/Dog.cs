using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExample
{
    public class Dog
    {
        //Field declaration
        private string name;

        //Constructor declaration
        public Dog()
        {
            this.name = null;
        }

        //Another constructor declaration
        public Dog(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Method declaration
        public void Bark()
        {
            Console.WriteLine("{0} said : Wow-wow!",name);
        }
    }
}
