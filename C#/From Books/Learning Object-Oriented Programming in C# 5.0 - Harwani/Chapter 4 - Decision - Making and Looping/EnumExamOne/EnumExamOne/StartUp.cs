using System;

namespace EnumExamOne
{
    public class StartUp
    {
        public enum Weekdays
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        };


        public static void DispDay(Weekdays dayss)
        {
            switch (dayss)
            {
                case Weekdays.Sunday:
                    Console.WriteLine("Sunday");
                    break;
                case Weekdays.Monday:
                    Console.WriteLine("Monday");
                    break;
                case Weekdays.Tuesday:
                    Console.WriteLine("Tuesday");
                    break;
                case Weekdays.Wednesday:
                    Console.WriteLine("Wednesday");
                    break;
                case Weekdays.Thursday:
                    Console.WriteLine("Thursday");
                    break;
                case Weekdays.Friday:
                    Console.WriteLine("Friday");
                    break;
                case Weekdays.Saturday:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    break;
            }
        }

        public static void Main()
        {
            Weekdays days;
            days = Weekdays.Tuesday;
            Console.WriteLine("Weekday is {0}",days);
            Console.WriteLine("Position of Thuesday in Enumerations is {0}",(int)days);
            DispDay(days);
        }
    }
}
