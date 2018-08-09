using System;

namespace VariableExamle
{
    public class StartUp
    {
        public static void Main()
        {
            //Declare some variables
            byte centuries = 20;
            ushort years = 2000;
            uint days = 730480;
            ulong hours = 17531520;

            //Print the result on the console
            Console.WriteLine($"{centuries} centuries are {years} years or {days} days or {hours} hours");

            ulong maxValue = UInt64.MaxValue;
            Console.WriteLine(maxValue);
        }
    }
}
