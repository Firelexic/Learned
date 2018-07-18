using System;

namespace DecimalType
{
    public class StartUp
    {
        public static void Main()
        {
            decimal amount, interest_rate, interest_amount, total_amount;
            amount = 100.50m;
            interest_rate = 12.24m;
            interest_amount = amount * interest_rate / 100;
            total_amount = amount + interest_amount;
            Console.WriteLine("Original amount is {0}," +
                "interest is {1} and amount with interest added is {2} ",amount,interest_amount,
                total_amount);
        }
    }
}
