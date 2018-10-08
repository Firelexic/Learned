using System;

namespace Generics
{
    public class StartUp
    {
        public static void Main()
        {
            AnimalsShelter<Dog> shelter = new AnimalsShelter<Dog>();
            shelter.Shelter(new Dog(HairSize.Small));
            shelter.Shelter(new Dog(HairSize.Normal));
            shelter.Shelter(new Dog(HairSize.Big));

            AnimalsShelter<Cat> catShelter = new AnimalsShelter<Cat>();
            catShelter.Shelter(new Cat());

            var firstdog = shelter.BringBackAnimal(2);
            Console.WriteLine(firstdog.SizeHair);
            

            
        }
    }
}
