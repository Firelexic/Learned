using System;
using System.Collections;

namespace ArrayListSecondExam
{
    public class StartUp
    {
        public static void Main()
        {
            ArrayList arrayOne = new ArrayList();
            ArrayList arrayTwo = new ArrayList();
            arrayOne.Add("Apple");
            arrayOne.Add("Mango");
            arrayOne.Add("Orange");
            arrayTwo.Add("IceCream");
            arrayTwo.Add("Sandwich");
            Console.WriteLine("The first ArrayList contains {0} element ",arrayOne.Count);
            Console.WriteLine("The second ArrayList {0} elements",arrayTwo.Count); ;
            arrayOne.Add(arrayTwo);
            Console.WriteLine("The first ArrayList now contains {0} elements as" +
                "show below : ",arrayOne.Count);
            foreach (var item in arrayOne)
            {
                Console.WriteLine(item);
            }
            arrayTwo.Clear();
            Console.WriteLine("The second ArrayList now contains {0} elements",arrayTwo.Count);
            arrayTwo.AddRange(arrayOne.GetRange(3, 2));
            Console.WriteLine("The second ArrayList now contains {0} elements as show below : ",arrayTwo.Count);
            foreach (var item in arrayTwo)
            {
                Console.WriteLine(item);
            }
            arrayOne.RemoveAt(0);
            Console.WriteLine("The first ArrayList after removing the first element has the following elements left : ");
            foreach (var item in arrayOne)
            {
                Console.WriteLine(item);
            }
            arrayOne.RemoveRange(2, 2);
            Console.WriteLine("The first ArrayList after removing the last two elements" +
                "has the following elements left : ");
            foreach (var item in arrayOne)
            {
                Console.WriteLine(item);
            }
            arrayOne.Insert(0, "Apple");
            Console.WriteLine("The first ArrayList after inserting an element at the top" +
                "has the following elements : ");
            foreach (var item in arrayOne)
            {
                Console.WriteLine(item);
            }
            ArrayList arrayThree = arrayOne.GetRange(0, arrayOne.Count);
            Console.WriteLine("The third ArrayList is a copy of the first ArrayList and it" +
                "has the following elements: ");
            foreach (var item in arrayThree)
            {
                Console.WriteLine(item);
            }
        }
    }
}
