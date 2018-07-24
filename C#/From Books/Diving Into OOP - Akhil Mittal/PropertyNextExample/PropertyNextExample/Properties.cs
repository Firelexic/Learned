using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyNextExample
{
    public class Properties
    {
        private string name;
        private int age;


        public string Name
        {
            get { return name; }
            set
            {
                Console.WriteLine("Set Name Called");
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                Console.WriteLine("Set Age Called");
                age = value;
            }
        }
    }
}
