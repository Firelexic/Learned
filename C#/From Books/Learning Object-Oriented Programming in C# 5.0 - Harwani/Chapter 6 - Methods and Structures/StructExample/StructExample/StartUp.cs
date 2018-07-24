using System;

namespace StructExample
{
    struct Product 
    {
        public string code;
        public string productName;
        public double price;

        public Product(string c,string n,double p)
        {
            code = c;
            productName = n;
            price = p;
        }
    }


    public class StartUp
    {
        public static void Main()
        {
            Product pOne = new Product("C101", "Camera", 15.75);
            Product pTwo, pThree;
            Console.WriteLine("Information of first product - Product Code : {0} , Product " +
                "name : {1} , Product Price {2}",pOne.code,pOne.productName,pOne.price);

            pTwo = pOne;
            Console.WriteLine("Information of second product - Product Code : {0}, Product Name : {1}," +
                "Product Price {2}",pTwo.code,pTwo.productName,pTwo.price);

            pThree.code = "L102";
            pThree.productName = "Laptop";
            pThree.price = 800;
            Console.WriteLine("Information of third product - Product Code : {0}, Product" +
                "Name : {1} , Product Price {2} ",pThree.code,pThree.productName,pThree.price);
        }
    }
}
