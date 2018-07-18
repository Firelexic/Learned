using System;

namespace Methods
{
    public class StartUp
    {
        public static string GetWeight(out double theWeight)
        {
            theWeight = 10;
            return "Ten";
        }

        public static double LbToKg(double pounds = 5)
        {
            return (pounds * 0.4535937);
        }
        
        public static void KgToLb(ref double weight)
        {
            weight = (weight / 0.45359237);
        }

        public static void Main()
        {
            double weight;
            string num;
            num = GetWeight(out weight);
            Console.WriteLine($"{num} lb = {LbToKg(weight)} kg");
            KgToLb(ref weight);
            Console.WriteLine($"{num} kg = {weight} lb");

        }
    }
}
