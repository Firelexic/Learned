using System;

namespace Concatenate
{
    public class StartUp
    {
        public static void Main()
        {
            string age = "twenty six";
            string text = "He is " + age + " years old.";
            Console.WriteLine(text);


            int myAge = 26;
            string myText = "He is " + myAge + " years old";
            Console.WriteLine(myText);
        }
    }
}
