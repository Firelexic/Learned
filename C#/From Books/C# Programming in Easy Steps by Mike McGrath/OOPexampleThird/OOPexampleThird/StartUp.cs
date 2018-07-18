using System;

namespace OOPexampleThird
{
    public class StartUp
    {
        public static void Main()
        {
            Cat tigger = new Cat();

            string tagT = String.Format("{0} is a {1} year old {2} cat",
                tigger.GetNmae(), tigger.GetAge(), tigger.GetColor());

            Console.WriteLine(tagT);


            Cat smokey = new Cat();
            smokey.SetName("Smokey");
            smokey.SetAge(4);
            smokey.SetColor("Black");

            string tagS = String.Format("{0} is a {1} year old {2} cat",
                smokey.GetNmae(), smokey.GetAge(), smokey.GetColor());

            Console.WriteLine(tagS + smokey.cry());
        }
    }
}
