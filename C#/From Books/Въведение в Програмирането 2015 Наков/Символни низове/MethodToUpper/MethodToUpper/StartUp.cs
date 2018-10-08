using System;

namespace MethodToUpper
{
    public class StartUp
    {
        public static void Main()
        {
            string pass1 = "Parola";
            string pass2 = "PaRoLa";
            string pass3 = "parola";

            Console.WriteLine(pass1.ToUpper() == "PAROLA");
            Console.WriteLine(pass2.ToUpper() == "PAROLA");
            Console.WriteLine(pass3.ToUpper() == "PAROLA");
        }
    }
}
