using System;

namespace StringCompare
{
    public class StartUp
    {
        public static void Main()
        {
            string strOne, strTwo;
            Console.WriteLine("Enter two strings : ");
            strOne = Console.ReadLine();
            strTwo = Console.ReadLine();
            int n = strOne.CompareTo(strTwo);
            if (n == 0)
            {
                Console.WriteLine("The two string {0} and {1} are equal",strOne,strTwo);

            }
            else if (n < 0)
            {
                Console.WriteLine("The string {0} is smaller than {1}",strOne,strTwo);

            }
            else if (n > 0)
            {
                Console.WriteLine("The string {0} is greater that {1}",strOne,strTwo);
            }
        }
    }
}
