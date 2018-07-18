using System;

namespace OOPpolymorphism
{
    public class StartUp
    {
        static void describle(Bird obj)
        {
            obj.talk();
            obj.fly();
        }

        public static void Main()
        {
            Pigeon joey = new Pigeon();
            Chicken lola = new Chicken();

            describle(joey);
            describle(lola);
        }
    }
}
