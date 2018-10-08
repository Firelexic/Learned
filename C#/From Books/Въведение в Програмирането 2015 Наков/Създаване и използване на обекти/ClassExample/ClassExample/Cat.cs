using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExample
{
    public class Cat
    {
        //Field name
        private string name;
        //Field color
        private string color;

        public string Name
        {
            //Getter of the property "Name"
            get { return this.name; }
            set { this.name = value; }
        }

        public string Color
        {
            //Getter of the property "Color"
            get { return this.color; }
            set { this.name = value; }
        }

        public Cat()
        {
            this.name = "Unnamed";
            this.color = "gray";
        }
        //Constructor with parameters
        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        //Method SayMiau
        public void SayMiau()
        {
            Console.WriteLine("Cat {0} said : Miauuu !",name);
        }

    }
}
