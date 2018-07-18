using System;

namespace Switch
{
    public class StartUp
    {
        public static void Main()
        {
            int num = 3;
            string day;
            switch (num)
            {
                case 1:
                    day = "Monday";
                    break;
                case 2:
                    day = "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "Saturday";
                    break;
                case 7:
                    day = "Sunday";
                    break;
                default:
                    day = "You know more then 7 days in week !?!?!";
                    break;
            }
            Console.WriteLine($"Day {num} : {day}");
        }
    }
}
