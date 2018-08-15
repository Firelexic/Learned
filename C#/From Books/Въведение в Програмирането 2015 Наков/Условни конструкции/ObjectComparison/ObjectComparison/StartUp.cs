using System;

namespace ObjectComparison
{
    public class StartUp
    {
        public static void Main()
        {
            string str = "beer";
            string anotherStr = str;
            string thirdStr = "be" + 'e' + 'r';
            Console.WriteLine("str = {0}",str);
            Console.WriteLine("anotherStr = {0}",anotherStr);
            Console.WriteLine("third = {0}",thirdStr);
            Console.WriteLine(str == anotherStr);
            Console.WriteLine(str == thirdStr);
            Console.WriteLine((object)str == (object)anotherStr);
            Console.WriteLine((object)str == (object)thirdStr);
        }
    }
}
