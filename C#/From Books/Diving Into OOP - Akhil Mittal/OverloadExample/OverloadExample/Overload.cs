﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadExample
{
    public class Overload
    {
        public void Display()
        {
            DisplayOverload(100, 200, 300);
            DisplayOverload(200, 100);
            DisplayOverload(200);
        }

        private void DisplayOverload(int a,params int[] parameterArray)
        {
            foreach (var i in parameterArray)
            {
                Console.WriteLine(i + " " + a);
            }
        }
    }
}
