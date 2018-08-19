using System;

namespace TotalAmountForBooks
{
    public class StartUp
    {
        

        public static void PrintTotalAmountForBooks(decimal[] price,string[] name)
        {


            decimal totalAmount = 0;
            foreach (decimal singleBookPrice in price)
            {
                totalAmount += singleBookPrice;
            }
            for (int i = 0; i < price.Length; i++)
            {
                Console.Write("{0} = {1:C2}",name[i],price[i]);
                Console.WriteLine();
            }

            Console.WriteLine("The total amount of all books is : " + totalAmount);
        }

        public static void Main()
        {
            Console.WriteLine("How much books you will buy ? ");
            int numberBook = int.Parse(Console.ReadLine());
            decimal[] books = new decimal[numberBook];
            string[] namebooks = new string[numberBook];

            for (int i = 0; i < namebooks.Length; i++)
            {
                Console.WriteLine("Name of book : ");
                namebooks[i] = Console.ReadLine();
                Console.WriteLine("How much money is : ");
                books[i] = decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine("You bought this : ");
            PrintTotalAmountForBooks(books, namebooks);
        }
    }
}
