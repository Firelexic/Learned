using System;
using System.Collections.Generic;
using System.Text;

namespace NonStaticMethod
{
    public class Dog
    {
        static int dogCount;

        private string name;
        private int age;

        public Dog(string name,int age)
        {
            this.name = name;
            this.age = age;

            dogCount += 1;
        }

        public void Bark()
        {
            Console.WriteLine("Wow");
        }

        public void PrintInfo()
        {
            Console.WriteLine("Dog's name : " + this.name + "; age : " + this.age + " ; often says: ");
            this.Bark();
        }

    }
}
