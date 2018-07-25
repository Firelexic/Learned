using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOrFunctions
{
    public class ShanuHouseClass
    {
        private int noOfTV = 2;
        private string yourTVName = "Samsung";
        private int noOfChair;
        private string YourTvName;

        public void myFirstMethod()
        {
            Console.WriteLine("You Have total " + noOfTV + "no of TV : ");
            Console.WriteLine("Your TV Name is : " + yourTVName);
        }

        public void Veranda()
        {
            Console.WriteLine("Welcome to Veranda");
            Console.WriteLine("How many chairs Do you have in your Veranda");
            noOfChair = int.Parse(Console.ReadLine());
            Console.WriteLine("I have total " + noOfChair + "Chairs in my Veranda");
        }

        public string TVNAME()
        {
            Console.WriteLine("Enter your Tv brand name");
            yourTVName = Console.ReadLine();
            return yourTVName;
        }
    }
}
