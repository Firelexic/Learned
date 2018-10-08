using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public enum HairSize
    {
        Small = 3,
        Normal = 5,
        Big = 10
    }

    public class Dog
    {
        private HairSize sizeHair;
        private string name;
       
        public Dog(HairSize sizeHair)
        {
            this.sizeHair = sizeHair;
        }

        public HairSize SizeHair
        {
            get { return this.sizeHair; }

        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }

}
