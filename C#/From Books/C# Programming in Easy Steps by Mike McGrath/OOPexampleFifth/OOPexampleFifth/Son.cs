using System;
using System.Collections.Generic;
using System.Text;

namespace OOPexampleFifth
{
    public class Son : Parent
    {
        public Son()
        {
            Console.WriteLine("Son Called");
        }
        public Son(int num) : base(num)
        {
            Console.WriteLine("Son + Called : " + num);
        }
    }
}
