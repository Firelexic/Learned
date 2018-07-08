using System;

namespace SwitchWithEnum
{
    class SwitchWithEnum
    {
        public enum State { Active = 1, Inactive = 2}

        static void Main()
        {
            State state = State.Active;

            switch (state)
            {
                case State.Active:
                    Console.WriteLine("Active");
                    break;
                case State.Inactive:
                    Console.WriteLine("Inactive");
                    break;
                default:
                    throw new Exception(String.Format("Unknown state : {0}", state));
                    
            }
        }
    }
}
