using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlastExample
{
    public class Sailboat
    {
        private string make;
        private string model;

        public Sailboat(string make,string model)
        {
            this.make = make;
            this.model = model;
        }

        public void Describe()
        {
            Console.WriteLine("Sailboat : {0}{1}",make,model);
        }
    }
}
