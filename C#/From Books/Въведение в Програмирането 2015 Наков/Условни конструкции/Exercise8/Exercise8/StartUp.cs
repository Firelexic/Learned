using System;

namespace Exercise8
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("What you want string,double or int");
            string input = Console.ReadLine();
            
            Console.WriteLine("Enter your text");
            if (input == "string")
            {
                string str = Console.ReadLine();
                Console.WriteLine("{0}*",str);
            }
            else if (input == "int")
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number + 1);
            }
            else
            {
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine(number + 1);
            }
            //With switch
            Console.WriteLine("What you want ? Write 0 for string 1 for int 2 for double");
            int numbers = int.Parse(Console.ReadLine());
            switch (numbers)
            {
                case 0:
                    string str = Console.ReadLine();
                    Console.WriteLine("{0}*",str);
                    break;
                case 1:
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine(num + 1);
                    break;
                case 2:
                    double numi = double.Parse(Console.ReadLine());
                    Console.WriteLine(numi + 1);
                    break;
                default:
                    break;
            }




        }
    }
}
