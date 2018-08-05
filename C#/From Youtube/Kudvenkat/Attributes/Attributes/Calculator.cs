using System;
using System.Collections.Generic;
using System.Text;

namespace Attributes
{
    public class Calculator
    {
        [Obsolete("Use Add(List<int> Numbers) Method")]
        public static int Add(int firstNumber,int secondNumber)
        {
            return firstNumber + secondNumber;
        }


        public static int Add(List<int> numbers)
        {
            int Sum = 0;
            foreach (int number in numbers)
            {
                Sum = Sum + number;
            }
            return Sum;
        }
    }
}
