using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    public class Student
    {
        private int id;
        private string name;
        private int passMask;

        public int Id
        {
            get { return this.id; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("id cant be negative ");
                }
                else
                {
                    this.id = value;
                }
               
            }
        }
    }
}
