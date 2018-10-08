using System;
using System.Collections.Generic;
using System.Text;

namespace DogAndKid
{
    public class Dog
    {
        private string name = "Sharo";

        public string Name
        {
            get { return this.name; }
        }

        public void Bark()
        {
            Console.WriteLine("wow-wow");
        }
        
        public void DoSth()
        {
            this.Bark();
        }
    }

    
}
