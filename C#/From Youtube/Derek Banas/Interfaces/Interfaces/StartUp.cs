using System;

namespace Interfaces
{
    public class StartUp
    {
        public static void Main()
        {
            Vehicle bike = new Vehicle("Bike", 4, 160);

            if (bike is IDrivable)
            {
                bike.Move();
                bike.Stop();
            }
            else
            {
                Console.WriteLine("The {0} can't be driven",bike.Brand);
            }

            IElectronicDevice TV = TVRemote.GetDevice();

            PowerButton powBut = new PowerButton(TV);

            powBut.Execute();
            powBut.Undo();
        }
    }
}
