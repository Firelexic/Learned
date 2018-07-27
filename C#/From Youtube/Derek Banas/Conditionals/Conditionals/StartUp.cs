using System;

namespace Conditionals
{
    public class StartUp
    {
        public static void Main()
        {
            int age = 17;

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to Elementary School");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle School");
            }
            else if ((age > 13) && (age < 19))
            {
                Console.WriteLine("Go to Hight School");
            }
            else
            {
                Console.WriteLine("Go to Collage");
            }

            if ((age < 14) || (age < 19))
            {
                Console.WriteLine("You Shouldn't work");
            }

            bool canDrive = age >= 16 ? true : false;

            switch(age)
            {
                case 1:
                case 2:
                    Console.WriteLine("Go to Day Care");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Go to Preschool");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("Go to another school");
                    break;
                default:
                    Console.WriteLine("go to another school");
                    break;
                    
            }
        }
    }
}
