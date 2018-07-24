using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyClassDemo
{
    public class Protperty
    {
        public string Name
        {
            get { return "I am a Name property "; }
        }

        public int Age
        {
            get
            {
                DateTime dateOfBirth = new DateTime(1984, 01, 20);
                DateTime currentDate = DateTime.Now;
                int age = currentDate.Year - dateOfBirth.Year;
                return age;
            }
        }
       

    }
}
