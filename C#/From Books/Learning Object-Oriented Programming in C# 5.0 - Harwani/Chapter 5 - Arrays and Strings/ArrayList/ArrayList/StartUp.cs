using System;
using System.Collections;

namespace ArrayLists
{
    public class StartUp
    {
        public static void Main()
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("How many fruits are there ? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the names of {0} fruits ",n);
            for (int i = 0; i <= n - 1; i++)
            {
                al.Add(Console.ReadLine());
            }
            Console.WriteLine("The fruit names entered are ");
            foreach (string element in al)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("The fruit names entered are : ");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
        }
    }
}
