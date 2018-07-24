using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadMethodsClass
{
    public class Overload
    {
        public void Display()
        {
            DisplayOverload(100, "Akhil", "Mittal", "OOP");
            DisplayOverload(200, "Akhil");
            DisplayOverload(300);
        }

        private void DisplayOverload(int a, params string[] parameterArray)
        {
            foreach (string str in parameterArray)
            {
                Console.WriteLine(str + " " + a);
            }
        }
    }
}
