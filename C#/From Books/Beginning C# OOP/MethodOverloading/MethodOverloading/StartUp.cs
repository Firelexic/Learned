using System;

namespace MethodOverloading
{
    public class StartUp
    {
        public static void Main()
        {
            HouseOwnerClass houseOwner = new HouseOwnerClass();

            houseOwner.BedRoom("My Name is Shanu I like Lavender Color");
            houseOwner.BedRoom("My Name is Afraz I like Light Blue color");
            houseOwner.BedRoom("Shanu", "Lavender");
        }
    }
}
