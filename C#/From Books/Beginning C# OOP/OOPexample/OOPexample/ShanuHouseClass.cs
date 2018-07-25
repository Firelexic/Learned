using System;
using System.Collections.Generic;
using System.Text;

namespace OOPexample
{
    public class ShanuHouseClass
    {
        private int noOfChair = 0;
        private string YourTVName;
        private bool doYouHaveTV = true;

        //Function with void and no parameter
        //here void means no return type
        public void Veranda()
        {
            Console.WriteLine("Welcome to Veranda");
            Console.WriteLine("How Many Chairs Do you have in your Veranda");
            noOfChair = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("I have total " + noOfChair + " chairs in my Veranda");
        }

        //Function with Return type as String
        public string TVName()
        {
            Console.WriteLine("Enter Your Tv Brand Name : ");
            YourTVName = Console.ReadLine();
            return YourTVName;
        }
        public void BedRoom(string nameandColor)
        {
            Console.WriteLine(nameandColor);
        }

        //Function with parameter
        public void BedRoom(string memberName,string color)
        {
            Console.WriteLine($"{memberName} Like {color} color");
        }
    }

    

}
