using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverloading
{
    public class HouseOwnerClass
    {
        //Function with parameter
        public void BedRoom(string nameandColor)
        {
            Console.WriteLine(nameandColor);
        }

        public void BedRoom(string memberName, string color)
        {
            Console.WriteLine($"{memberName} like {color} color");
        }

    }
}
