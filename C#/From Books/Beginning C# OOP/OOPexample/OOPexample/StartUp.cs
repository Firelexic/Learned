using System;

namespace OOPexample
{
    public class StartUp
    {
        public static void Main()
        {
            ShanuHouseClass objHouseOwner = new ShanuHouseClass();


            objHouseOwner.Veranda();

            //string returnvalue = objHouseOwner.TVName();
            Console.WriteLine("Your tv Brand name is : " + objHouseOwner.TVName());
            objHouseOwner.BedRoom("My name is Shanu I like Loavender color");
            objHouseOwner.BedRoom("My name is Afraz I like Light Blue color");
            objHouseOwner.BedRoom("Shanu", "Lavender");
        }
    }
}
