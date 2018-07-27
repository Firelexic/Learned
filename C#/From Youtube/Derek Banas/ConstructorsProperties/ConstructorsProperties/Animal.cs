using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructorsProperties
{
    public class Animal
    {
        private string name;
        private string sound;

        public const string Shelter = "Derek's home for animals";

        public readonly int idNum;

        public void MakeSound()
        {
            Console.WriteLine("{0} SAYS {1}",name,sound);
        }

        public Animal() : this("No Name", "No Sound") { }

        public Animal(string name,string sound)
        {
            SetName(name);
            Sound = sound;
        }

        public void SetName(string name)
        {
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
            else
            {
                this.name = "No Name";
                Console.WriteLine("Name can't contain numbers");
            }
        }

        public string GetName()
        {
            return name;
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("Sound is too long");
                }
                else
                {
                    sound = value;
                }
            }
        }

        public string Owner { get; set; } = "No Owner";
        public static int numOfAnimals = 0;

        public static int NumOfAnimal
        {
            get { return numOfAnimals; }
            set
            {
                NumOfAnimal += value;
            }
        }
    }
}
