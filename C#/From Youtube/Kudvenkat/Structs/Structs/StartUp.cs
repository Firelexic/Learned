using System;

namespace Structs
{
    public struct Customer
    {
        public int id;
        public string name;


        public Customer(string name)
        {

            this.Name = name;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name { get; set; }
        
    }




    public class StartUp
    {
        public static void Main()
        {
            
        }
    }
}
