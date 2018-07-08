using System;

namespace SwitchSecondExample
{
    class SwitchSecondExample
    {
        static void Main()
        {
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                case 2:
                    Console.WriteLine("One or Two");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Three or Four");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("Five or Six");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("Seven or Eight");
                    break;
                case 9:
                case 10:
                    Console.WriteLine("Nine or Ten");
                    break;
                default:
                    Console.WriteLine("Other number more than 10");
                    break;
            }
        }
    }
}
