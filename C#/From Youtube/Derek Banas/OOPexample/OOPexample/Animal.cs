using System;
using System.Collections.Generic;
using System.Text;

namespace OOPexample
{
    public class Animal
    {
        public string name;
        public string sound;

        public Animal(string name,string sound)
        {
            name = "No name";
            sound = "No sound";
            numOfAnimal++;
        }

        public Animal(string name = "No name")
        {
            this.name = name;
            this.sound = "No Sound";
            numOfAnimal++;
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}",name,sound);
        }

        static int numOfAnimal = 0;

        public static int GetNumAnimals()
        {
            return numOfAnimal;
        }
    }
}
