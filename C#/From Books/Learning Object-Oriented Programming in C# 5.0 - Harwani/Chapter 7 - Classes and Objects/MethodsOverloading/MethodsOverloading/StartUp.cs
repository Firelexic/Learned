using System;

namespace MethodsOverloading
{
    public class StartUp
    {
        public static void Main()
        {
            AddVal av = new AddVal();
            av.ComputeSum(5);
            av.ComputeSum(5, 8);
            av.ComputeSum(5, 9.17);
            av.ComputeSum(3.782, 9.17);
        }
    }
}
