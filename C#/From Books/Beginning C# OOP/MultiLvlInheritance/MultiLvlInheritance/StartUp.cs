using System;

namespace MultiLvlInheritance
{
    public class Program
    {
        public static void Main()
        {
            DerivedClassTwo derived = new DerivedClassTwo();
            derived.PublicMethod();
            derived.DerivedClassMethod();
        }
    }
}
