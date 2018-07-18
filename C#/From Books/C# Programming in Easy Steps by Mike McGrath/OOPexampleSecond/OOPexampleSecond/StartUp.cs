using System;

namespace OOPexampleSecond
{
    public class StartUp
    {
        public static void Main()
        {
            Dog fido = new Dog();
            fido.SetValue("Fido", 3, "Brown");

            string tagf = String.Format("{0} is a {1} year old {2} dog",
                fido.GetName(), fido.GetAge(), fido.GetColor());

            Console.WriteLine(tagf + fido.Bark());

            Dog lucy = new Dog();
            lucy.SetValue("Lucy", 2, "Gray");

            string tagL = String.Format("{0} is a {1} year old {2} dog ",
                lucy.GetName(), lucy.GetAge(), lucy.GetColor());

            Console.WriteLine(tagL + lucy.Bark());
        }
    }
}
