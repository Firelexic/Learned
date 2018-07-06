using System;

namespace ComparingStringTwo
{
    class ComparingStringTwo
    {
        static void Main()
        {
            string strOne = "ZetCode";
            string strTwo = "zetcode";

            Console.WriteLine(string.Compare(strOne,strTwo,true));
            Console.WriteLine(string.Compare(strOne,strTwo,false));
        }
    }
}
