using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyClassExample
{
    public class Properties
    {
        public string Name
        {
            get { return "I am a Name property"; }
        }

        public int Age
        {
            get
            {
                DateTime dateOfBirth = new DateTime(1996, 01, 04);
                DateTime currentDate = DateTime.Now;
                int age = currentDate.Year - dateOfBirth.Year;
                Console.WriteLine("Get Age Called");
                return age;

            }

            set
            {
                Console.WriteLine("Set Age called " + value);
            }
        }
    }
}
